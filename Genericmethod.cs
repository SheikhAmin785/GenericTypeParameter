using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypeParameter
{
    class Genericmethod
    {
        public void Show<T>(T mes)
        {
            Console.WriteLine(mes);
        }
        static void Meto()
        {
            Genericmethod objj = new Genericmethod();
            objj.Show("this is generic method");
        }
    }
}
