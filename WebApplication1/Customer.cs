using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WebApplication1
{
    [DataContract]
    public class Customer
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string CustomerName { get; set; }
        [DataMember]
        public string CusomerAddres { get; set; }
        [DataMember]
        public int CusomerPhone { get; set; }
        [DataMember]
        public string Remark { get; set; }

    }
}
