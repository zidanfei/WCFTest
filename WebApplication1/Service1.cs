using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1
{
    [ServiceContract(Namespace = "http://www.artech.com/")]
    public interface ICustomerService
    {
        [WebGet(UriTemplate = "GetCusomerName")]
        [OperationContract]
        string GetCusomerName(string customercode);

        [WebGet(UriTemplate = "GetCustomer")]
        [OperationContract]
        Customer GetCustomer(Customer customer);

        [WebGet(UriTemplate = "GetAllCustomerList")]
        [OperationContract]
        List<Customer> GetAllCustomerList();
    }

    //[ServiceExport(typeof(ISyncGroupService))]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class CustomerService : ICustomerService
    {
        public string GetCusomerName(string customercode)
        {
            return "惠森药业有限公司";
        }

        public Customer GetCustomer(Customer customer)
        {
            return new Customer()
            {
                id = 11,
                CustomerName = "惠森药业有限公司",
                CusomerAddres = "新疆",
                CusomerPhone = 1626772323,
                Remark = "无"
            };
        }

        public List<Customer> GetAllCustomerList()
        {
            List<Customer> cus = new List<Customer>();
            cus.Add(new Customer()
            {
                id = 11,
                CustomerName = "惠森药业有限公司",
                CusomerAddres = "新疆",
                CusomerPhone = 1626772323,
                Remark = "无"
            });
            cus.Add(new Customer()
            {
                id = 12,
                CustomerName = "黄河药业有限公司",
                CusomerAddres = "新疆",
                CusomerPhone = 1626772323,
                Remark = "无"

            });
            cus.Add(new Customer()
            {
                id = 13,
                CustomerName = "长江药业有限公司",
                CusomerAddres = "新疆",
                CusomerPhone = 1626772323,
                Remark = "无"

            });
            return cus;
        }
    }
}
