using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WcfService1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //WcfService1.ServiceReference1.CustomerServiceClient client = new ServiceReference1.CustomerServiceClient();
            //var data = client.GetAllCustomerList();
            //SyncUnitService.SyncUnitServiceClient suclient = new SyncUnitService.SyncUnitServiceClient();
            //var result = suclient.Execute("Job0_OrgUnitSyncGroup", "SendEmail_NewUserSync");

            ChannelFactory<SyncUnitService.ISyncUnitService> UserClient = new ChannelFactory<SyncUnitService.ISyncUnitService>("WSHttpBinding_ISyncUnitService");

            UserClient.Credentials.UserName.UserName = "test";
            UserClient.Credentials.UserName.Password = "test";
            var client = UserClient.CreateChannel();
            var result = client.Execute("Job0_OrgUnitSyncGroup", "SendEmail_NewUserSync");

        }
    }
}