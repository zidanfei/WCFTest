
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Web;



namespace WebAppClient
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {


            //InitHost();
            try
            {
                //using (WebServiceHost host = new WebServiceHost(typeof(CustomerService)))
                //{
                //    host.Open();
                //    Console.Read();
                //}
            }
            catch (Exception e)
            {

            }

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }


    }
}
