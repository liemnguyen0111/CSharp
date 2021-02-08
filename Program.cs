using System;

namespace day1
{
    class Program
    {
        static void Main(string[] args)
        {

            int length, breadth;

            length = 4;
            breadth = 5;

            int area = length * breadth;
            
            int l,b,a;
            Console.WriteLine("Input length of rectangle: ");
            l = Convert.ToInt32(Console.ReadLine());

              Console.WriteLine("Input breadth of rectangle: ");
            b = Convert.ToInt32(Console.ReadLine());

            a = l * b;

           Console.WriteLine("Total area: {0}", a);

            // int? num1 = null;
            // int? num2 = 123;
            // int num3;

            // num3 = num1 ?? 234;
            // Console.WriteLine("num3 is {0} ", num3);

            // num3 = num1 ?? 123;
            // Console.WriteLine("num3 is {0} " , num3);
        }
    }
}
