using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Class1
    {

        public string MyMethod(string str)
        {
            return str;
        }

        public string GetPar()
        {
            ClassLibrary1.Class1 c = new ClassLibrary1.Class1();
            return c.GetPar();
        }
    }
}
