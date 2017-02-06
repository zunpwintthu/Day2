using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program2
    {
        public static void Main()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine(a + b);
            double c = 70.8;
            double d = 100.1;
            Console.WriteLine(c + d);
            Console.WriteLine(a + c);
            Console.WriteLine("He weighs {0:0.000} kg and is {1:0.000} cm tall", c, d);
            double balance = 12345.67891345;
           double bal = 123456789123456;
            Console.WriteLine("${0}", balance);//12345.678912345
            Console.WriteLine("${0:00.00}", balance);//12345.68
            Console.WriteLine("${0:0,000.00}", balance);
            Console.WriteLine("${0:0,000.00}", bal);

            double x = 123;
            double y = 33.334;
            Console.WriteLine("{0} {1}", x, y);
            Console.WriteLine("{0:0.0} {1:0.0}", x, y);
            Console.WriteLine("{0:#.#} {1:#.#}", x, y);

            Console.WriteLine("{0:0000}", x);//0123
            Console.WriteLine("{0:#}", x);//123;
            Console.WriteLine("{0:##00}", x);//123
        }       
    }
}
