using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypeParameter
{
    class AlaminClass
    {
        private string name;

        public AlaminClass(string name)
        {
            this.name = name;
        }
        public string name
        {
            get { return name; }
            set { name = value; }
        }
    }
    public static void Mains()
    {
        AlaminClass obj = new AlaminClass("alamin");
        
    }
   
}
