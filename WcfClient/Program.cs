using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfClient
{
    class Program
    {
        static void Main(string[] args)
        {


            //UserClient.Credentials.UserName.UserName = "admin";
            //UserClient.Credentials.UserName.Password = "6F79EC28B37A4063B1EDECEE8D10AB0F";
            //var client = UserClient.CreateChannel();
            //var result = client.Execute("Job0_OrgUnitSyncGroup", "TempOrgTypeUnitSync");
            //Org_OrgServices.IOrganizationService oService = new Org_OrgServices.OrganizationServiceClient();
            //var o = oService.FindById("114e8eaf-4391-484c-8d33-d3029b7a0ac7");

            //Org_userservice.IUserService uService = new Org_userservice.UserServiceClient();
            //var u = uService.FindById("0002f479-d685-4f14-8b31-b6c440ee4272");


            //ChannelFactory<CustomerServices.ICustomerService> custome = new ChannelFactory<CustomerServices.ICustomerService>();


            //ChannelFactory<ClaimsAwareWebServices.IClaimsAwareWebService> UserClient = new ChannelFactory<ClaimsAwareWebServices.IClaimsAwareWebService>("WSHttpBinding_ICustomerService");
            //var client = UserClient.CreateChannel();
            //var datas = client.GetAllCustomerList(new WcfClient.CustomerServices.GetAllCustomerListRequest());


            ServiceTest();
            //LocalServiceTest();
            Console.ReadLine();

        }


        static void ServiceTest()
        {
            ClaimsAwareWebServices.ClaimsAwareWebServiceClient client = new ClaimsAwareWebServices.ClaimsAwareWebServiceClient();
            //client.se
            var cert = client.ClientCredentials.ClientCertificate.Certificate;
            client.ClientCredentials.UserName.UserName = "IWS-CHLIU\administrator";
            client.ClientCredentials.UserName.Password = "2wsx@WSX"; 

            //var res = client.ComputeResponse("dafdsa");
            //Console.WriteLine(res);


            //ChannelFactory<ClaimsAwareWebServices.IClaimsAwareWebService> UserClient = new ChannelFactory<ClaimsAwareWebServices.IClaimsAwareWebService>("WS2007FederationHttpBinding_IClaimsAwareWebService");

            //UserClient.Credentials.UserName.UserName = "IWS-CHLIU\administrator";
            //UserClient.Credentials.UserName.Password = "2wsx@WSX";
            //var client = UserClient.CreateChannel();
            var res = client.ComputeResponse("dafdsa");
            Console.WriteLine(res);
        }

        static void LocalServiceTest()
        {
            LocalClaimsAwareWebServices.IClaimsAwareWebService client = new LocalClaimsAwareWebServices.ClaimsAwareWebServiceClient();
            var res = client.ComputeResponse("dafdsa");
            Console.WriteLine(res);
        }
    }
}
