using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Non_Primitive_types
{
    internal class Person
    {
        public string Name { get; set; }
        public void introduce()
        {
            Console.WriteLine("Hello, my name is {0}", Name);
        }
        public static int calculate(int a, int b)
        {
            return a + b;
        }
    }
}
