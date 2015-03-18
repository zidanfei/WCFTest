using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace WCFHost
{
    class Program
    {
        static void Main(string[] args)
        {
            

            InitWebHostNoConfig();
        }
        static void InitWCFHost()
        {
            ServiceHost serviceHost = new ServiceHost(typeof(WCFHost.CustomerService));
            serviceHost.Open();
            Console.ReadLine();
        }

        static void InitWebHost()
        {
            WebServiceHost serviceHost = new WebServiceHost(typeof(WCFHost.CustomerService));
            serviceHost.Open();
            Console.ReadLine();
        }

        static void InitWebHostNoConfig()
        {
            //WS2007FederationHttpBinding binding = new WS2007FederationHttpBinding();
            //binding.Security.Message.IssuerAddress = new EndpointAddress("http://localhost:8077/SecurityTokenService");
            //binding.Security.Message.IssuerMetadataAddress = new EndpointAddress("http://localhost:8077/SecurityTokenService/mex");

            WebHttpBinding binding = new WebHttpBinding();
            binding.Security.Mode = WebHttpSecurityMode.Transport;

            Uri serviceUri = new Uri("https://10.0.2.10:6022/ClaimsAwareWebService");
            WebServiceHost host = new WebServiceHost(typeof(CustomerService), serviceUri);

            host.AddServiceEndpoint(typeof(ICustomerService), binding, "");

            // Configure our certificate and issuer certificate validation settings on the service credentials
            host.Credentials.ServiceCertificate.SetCertificate("CN=iWSApp", StoreLocation.LocalMachine, StoreName.My);

            // Enable metadata generation via HTTP GET
            ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;
            host.Description.Behaviors.Add(smb);

            host.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexHttpBinding(), "mex");


            // Configure the service host to use the Windows Identity Foundation
            //Microsoft.IdentityModel.Configuration.ServiceConfiguration configuration = new Microsoft.IdentityModel.Configuration.ServiceConfiguration();
            //configuration.IssuerNameRegistry = new TrustedIssuerNameRegistry();
            //configuration.SecurityTokenHandlers.Configuration.AudienceRestriction.AllowedAudienceUris.Add(serviceUri);

            //FederatedServiceCredentials.ConfigureServiceHost(host, configuration);

            host.Open();


            Console.WriteLine("服务启动 " + serviceUri.AbsoluteUri);
            Console.ReadLine();

            //host.Close();                 

        }
    }
}
