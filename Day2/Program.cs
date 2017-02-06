using System;
namespace Day2
{
    class Program1
    {
        public static void Main()
        {
            System.Console.WriteLine("1");//1
            System.Console.Write("2");
            System.Console.Write("3");
            System.Console.WriteLine("4");//234
            System.Console.WriteLine("5"+"6"+"7");//567
            System.Console.WriteLine("6");
            System.Console.WriteLine("Welcome to ISS");
            int a = 5;
            Console.WriteLine(a);//5
            int b = 10;
            Console.WriteLine(a + b);//15
            Console.WriteLine("She says \"Hello\\\"");
            Console.WriteLine("{0}+{1}={2}" , a, b, a + b);
            Console.WriteLine("{2}={1}+{0}", a, b, a + b);
                
        }
    }

}
