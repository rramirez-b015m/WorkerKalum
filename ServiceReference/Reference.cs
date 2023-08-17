﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference
{
    using System.Runtime.Serialization;
    
      [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IEnrollmentService")]
    public interface IEnrollmentService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEnrollmentService/Test", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> TestAsync(string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEnrollmentService/EnrollmentProcess", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReference.EnrollmentResponse> EnrollmentProcessAsync(ServiceReference.EnrollmentRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEnrollmentService/StudentBalance", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReference.StudentBalanceResponse1> StudentBalanceAsync(ServiceReference.StudentBalanceRequest1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEnrollmentService/CandidateRecordProcess", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReference.AspiranteResponse> CandidateRecordProcessAsync(ServiceReference.AspiranteRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class EnrollmentRequest
    {
        
        private string NoExpedienteField;
        
        private string CicloField;
        
        private int MesInicioPagoField;
        
        private string CarreraIdField;
        
        private string InscripcionCargoIdField;
        
        private string CarneCargoIdField;
        
        private string CargoMensualIdField;
        
        private string DiaPagoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string NoExpediente
        {
            get
            {
                return this.NoExpedienteField;
            }
            set
            {
                this.NoExpedienteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Ciclo
        {
            get
            {
                return this.CicloField;
            }
            set
            {
                this.CicloField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public int MesInicioPago
        {
            get
            {
                return this.MesInicioPagoField;
            }
            set
            {
                this.MesInicioPagoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string CarreraId
        {
            get
            {
                return this.CarreraIdField;
            }
            set
            {
                this.CarreraIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string InscripcionCargoId
        {
            get
            {
                return this.InscripcionCargoIdField;
            }
            set
            {
                this.InscripcionCargoIdField = value;
            }
        }
        
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string CarneCargoId
        {
            get
            {
                return this.CarneCargoIdField;
            }
            set
            {
                this.CarneCargoIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string CargoMensualId
        {
            get
            {
                return this.CargoMensualIdField;
            }
            set
            {
                this.CargoMensualIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string DiaPago
        {
            get
            {
                return this.DiaPagoField;
            }
            set
            {
                this.DiaPagoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class AspiranteResponse
    {
        
        private int statusCodeField;
        
        private string messageField;
        
        private string noExpedienteField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int StatusCode
        {
            get
            {
                return this.statusCodeField;
            }
            set
            {
                this.statusCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string NoExpediente
        {
            get
            {
                return this.noExpedienteField;
            }
            set
            {
                this.noExpedienteField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class AspiranteRequest
    {
        
        private string apellidosField;
        
        private string nombresField;
        
        private string direccionField;
        
        private string telefonoField;
        
        private string emailField;
        
        private string carreraIdField;
        
        private string examenIdField;
        
        private string jornadaIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Apellidos
        {
            get
            {
                return this.apellidosField;
            }
            set
            {
                this.apellidosField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Nombres
        {
            get
            {
                return this.nombresField;
            }
            set
            {
                this.nombresField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Direccion
        {
            get
            {
                return this.direccionField;
            }
            set
            {
                this.direccionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Telefono
        {
            get
            {
                return this.telefonoField;
            }
            set
            {
                this.telefonoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string Email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string CarreraId
        {
            get
            {
                return this.carreraIdField;
            }
            set
            {
                this.carreraIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string ExamenId
        {
            get
            {
                return this.examenIdField;
            }
            set
            {
                this.examenIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string JornadaId
        {
            get
            {
                return this.jornadaIdField;
            }
            set
            {
                this.jornadaIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class StudentBalanceResponse
    {
        
        private string anioField;
        
        private string correlativoField;
        
        private string descripcionField;
        
        private System.DateTime fechaCargoField;
        
        private System.DateTime fechaAplicaField;
        
        private decimal montoField;
        
        private decimal moraField;
        
        private decimal descuentoField;
        
        private decimal totalField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Anio
        {
            get
            {
                return this.anioField;
            }
            set
            {
                this.anioField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Correlativo
        {
            get
            {
                return this.correlativoField;
            }
            set
            {
                this.correlativoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Descripcion
        {
            get
            {
                return this.descripcionField;
            }
            set
            {
                this.descripcionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public System.DateTime FechaCargo
        {
            get
            {
                return this.fechaCargoField;
            }
            set
            {
                this.fechaCargoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public System.DateTime FechaAplica
        {
            get
            {
                return this.fechaAplicaField;
            }
            set
            {
                this.fechaAplicaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public decimal Monto
        {
            get
            {
                return this.montoField;
            }
            set
            {
                this.montoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public decimal Mora
        {
            get
            {
                return this.moraField;
            }
            set
            {
                this.moraField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public decimal Descuento
        {
            get
            {
                return this.descuentoField;
            }
            set
            {
                this.descuentoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public decimal Total
        {
            get
            {
                return this.totalField;
            }
            set
            {
                this.totalField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class StudentBalanceRequest
    {
        
        private string carneField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Carne
        {
            get
            {
                return this.carneField;
            }
            set
            {
                this.carneField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class EnrollmentResponse
    {
        
        private int statusCodeField;
        
        private string messageField;
        
        private string carneField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int StatusCode
        {
            get
            {
                return this.statusCodeField;
            }
            set
            {
                this.statusCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Carne
        {
            get
            {
                return this.carneField;
            }
            set
            {
                this.carneField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="StudentBalance", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class StudentBalanceRequest1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public ServiceReference.StudentBalanceRequest request;
        
        public StudentBalanceRequest1()
        {
        }
        
        public StudentBalanceRequest1(ServiceReference.StudentBalanceRequest request)
        {
            this.request = request;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="StudentBalanceResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class StudentBalanceResponse1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public ServiceReference.StudentBalanceResponse[] StudentBalanceResult;
        
        public StudentBalanceResponse1()
        {
        }
        
        public StudentBalanceResponse1(ServiceReference.StudentBalanceResponse[] StudentBalanceResult)
        {
            this.StudentBalanceResult = StudentBalanceResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface IEnrollmentServiceChannel : ServiceReference.IEnrollmentService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class EnrollmentServiceClient : System.ServiceModel.ClientBase<ServiceReference.IEnrollmentService>, ServiceReference.IEnrollmentService
    {
        
        /// <summary>
        /// Implemente este método parcial para configurar el punto de conexión de servicio.
        /// </summary>
        /// <param name="serviceEndpoint">El punto de conexión para configurar</param>
        /// <param name="clientCredentials">Credenciales de cliente</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public EnrollmentServiceClient() : 
                base(EnrollmentServiceClient.GetDefaultBinding(), EnrollmentServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IEnrollmentService_soap.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public EnrollmentServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(EnrollmentServiceClient.GetBindingForEndpoint(endpointConfiguration), EnrollmentServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public EnrollmentServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(EnrollmentServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public EnrollmentServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(EnrollmentServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public EnrollmentServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<string> TestAsync(string message)
        {
            return base.Channel.TestAsync(message);
        }
        
        public System.Threading.Tasks.Task<ServiceReference.EnrollmentResponse> EnrollmentProcessAsync(ServiceReference.EnrollmentRequest request)
        {
            return base.Channel.EnrollmentProcessAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference.StudentBalanceResponse1> ServiceReference.IEnrollmentService.StudentBalanceAsync(ServiceReference.StudentBalanceRequest1 request)
        {
            return base.Channel.StudentBalanceAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference.StudentBalanceResponse1> StudentBalanceAsync(ServiceReference.StudentBalanceRequest request)
        {
            ServiceReference.StudentBalanceRequest1 inValue = new ServiceReference.StudentBalanceRequest1();
            inValue.request = request;
            return ((ServiceReference.IEnrollmentService)(this)).StudentBalanceAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<ServiceReference.AspiranteResponse> CandidateRecordProcessAsync(ServiceReference.AspiranteRequest request)
        {
            return base.Channel.CandidateRecordProcessAsync(request);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IEnrollmentService_soap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IEnrollmentService_soap))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:5275/EnrollmentService.asmx");
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return EnrollmentServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IEnrollmentService_soap);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return EnrollmentServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IEnrollmentService_soap);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IEnrollmentService_soap,
        }
    }
}