using System;

namespace GenericTypeParameter
{
    class Program
    {
        public class Student<T>
        {
            public T data;

            public Student(T data)
            {
                this.data = data;
                Console.WriteLine("data passed", this.data);

            }


        }
        static void Main()
        {
            Student<string> getdata = new Student<string>("alamin");

            Student<int> getdataID = new Student<int>(20);

        }
    }
}
