using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Configuration;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using ServiceReference;
using WorkerQueueManagement.Models;

public class Program
{
    private static IModel channel = null;

    private static IConfiguration Configuration = null;

    public static void Main(string[] args)
    {


        var environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
        var builder = new ConfigurationBuilder();
        builder.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile($"appsettings.Development.json", optional: false, reloadOnChange: true);
        Configuration = builder.Build();
        ConnectionFactory connectionFactory = new ConnectionFactory();
        IConnection conexion = null;
        connectionFactory.HostName = Configuration.GetValue<string>("RabbitConfiguration:Host");
        connectionFactory.VirtualHost = "/";
        connectionFactory.Port = Configuration.GetValue<int>("RabbitConfiguration:Port");
        connectionFactory.UserName = Configuration.GetValue<string>("RabbitConfiguration:UserName");
        connectionFactory.Password = Configuration.GetValue<string>("RabbitConfiguration:Password");
        conexion = connectionFactory.CreateConnection();
        channel = conexion.CreateModel();
        var consumer = new EventingBasicConsumer(channel);
        var consumerAlumno = new EventingBasicConsumer(channel);
        consumer.Received += ConsumerMessageReceived;
        consumerAlumno.Received += ConsumerMessageAlumnoReceived;
        var consumerTag = channel.BasicConsume(Configuration.GetValue<string>("RabbitConfiguration:Queue"), true, consumer);
        var consumeAlumnoTag = channel.BasicConsume(Configuration.GetValue<string>("RabbitConfiguration:QueueAlumno"),true,consumerAlumno);
        Console.WriteLine("Presiona una tecla para finalizar la lectura de los mensajes");
        Console.ReadLine();
    }

    public static async void ConsumerMessageReceived(object? sender, BasicDeliverEventArgs e)
    {


        string message = Encoding.UTF8.GetString(e.Body.ToArray());
        AspiranteRequest request = JsonSerializer.Deserialize<AspiranteRequest>(message);
        AspiranteResponse response = await ClientWebServiceAspirante(request);
        if(response.StatusCode == 201 || response.StatusCode == 200){
            HttpClient httpClient = new HttpClient();
            NotificationRequestDTO notificationRequest = new NotificationRequestDTO();
            notificationRequest.Email = request.Email;
            notificationRequest.Recipient = request.Email;
            notificationRequest.Subject = $"Generación de numero de expediente {response.NoExpediente}";
            notificationRequest.Body = $"http://localhost:4200/#/dashboard/update-identification/form?type=expediente&identificationId={response.NoExpediente}";
            notificationRequest.Type = "Expediente";
            notificationRequest.IdentificationId = response.NoExpediente;
            var json = JsonSerializer.Serialize(notificationRequest);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage httpResponse = await httpClient.PostAsync("http://localhost:5007/kalum-notification/v1/notification",data);
            var result = await httpResponse.Content.ReadAsByteArrayAsync();
            Console.WriteLine(result);
        }

        Console.WriteLine($"Se registró la solictud con el número de expediente {response.NoExpediente}");
    }

    public static async void ConsumerMessageAlumnoReceived(object? sender, BasicDeliverEventArgs e)
    {


        string message = Encoding.UTF8.GetString(e.Body.ToArray());
        EnrollmentRequest request = JsonSerializer.Deserialize<EnrollmentRequest>(message);
        EnrollmentResponse response = await ClientWebServiceAlumno(request);
        Console.WriteLine($"Se registró la solictud con el numero de carne {response.Carne}");

    }


    public static async Task<AspiranteResponse> ClientWebServiceAspirante(AspiranteRequest request)
    {
        AspiranteResponse aspiranteResponse = null;
        var client = new EnrollmentServiceClient(EnrollmentServiceClient.EndpointConfiguration.BasicHttpBinding_IEnrollmentService_soap,
        $"{Configuration.GetValue<string>("WebServicesConfiguration:Protocol")}://" +
        $"{Configuration.GetValue<string>("WebServicesConfiguration:Host")}:" +
        $"{Configuration.GetValue<string>("WebServicesConfiguration:Port")}" +
        $"{Configuration.GetValue<string>("WebServicesConfiguration:Path")}");

        var response = await client.CandidateRecordProcessAsync(request);
        aspiranteResponse = new AspiranteResponse()
        {
            StatusCode = response.StatusCode,
            NoExpediente = response.NoExpediente,
            Message = response.Message
        };

        return aspiranteResponse;
    }
    public static async Task<EnrollmentResponse> ClientWebServiceAlumno(EnrollmentRequest request)
    {
        EnrollmentResponse enrollmentResponse = null;
        var alumno = new EnrollmentServiceClient(EnrollmentServiceClient.EndpointConfiguration.BasicHttpBinding_IEnrollmentService_soap,
        $"{Configuration.GetValue<string>("WebServicesConfiguration:Protocol")}://" +
        $"{Configuration.GetValue<string>("WebServicesConfiguration:Host")}:" +
        $"{Configuration.GetValue<string>("WebServicesConfiguration:Port")}" +
        $"{Configuration.GetValue<string>("WebServicesConfiguration:Path")}");

        var response = await alumno.EnrollmentProcessAsync(request);
        enrollmentResponse = new EnrollmentResponse()
        {
           StatusCode = response.StatusCode,
           Message = response.Message,
           Carne = response.Carne
        };

        return enrollmentResponse;
    }
}