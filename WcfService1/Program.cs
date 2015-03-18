using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class Program
    {
        static void Main(string[] args)
        {
            WcfService1.ServiceReference1.CustomerServiceClient client = new ServiceReference1.CustomerServiceClient();
            var data = client.GetAllCustomerList();
        }
    }
}