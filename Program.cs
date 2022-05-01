using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region homework1
           
            Console.WriteLine("type number");
            var number = Convert.ToInt32(Console.ReadLine());
            if (number % 5 == 0)
                Console.WriteLine("Yes");
            else

                Console.WriteLine("No");
            
            #endregion

            #region homework3
           
            Console.WriteLine("enter x - ");
            var J = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("enter y - ");
            var K = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"y and x = {(J, K) = (K, J)}");
            
            #endregion

            #region homework4
            
            Console.WriteLine("multiplication Table");
            Console.WriteLine("Type num:");
            var j = Convert.ToInt32(Console.ReadLine());

            var i = 0;

                while (i <= 9)
            {
                i++;
                Console.WriteLine($"{j} * {i} = {j*i}");
            }
            
            #endregion

            #region homework5
            
            Console.WriteLine("Type num");
            var n = Convert.ToDecimal(Console.ReadLine());
            var T = 0;
            
            while (T < n)
            {
                T += 2;
                Console.WriteLine(T*T);
            }
           
            #endregion
            
            #region homework2

            Console.WriteLine("Enter x - ");
            var x = 0 + Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter y -");
            var y = 0 + Convert.ToDecimal(Console.ReadLine());
            while (x >= y)
            {
                if (x > y)
                {
                    Console.WriteLine($"{x + y}");
                    Console.WriteLine($"{x - y}");
                    Console.WriteLine($"{x * y}");
                    Console.WriteLine($"{x / y}");
                }
                else
                {
                    Console.WriteLine($"{x + y}");
                    Console.WriteLine($"{y - x}");
                    Console.WriteLine($"{x * y}");
                    Console.WriteLine($"{y / x}");
                }
                
            }
            if (x == 0)

            {
                Console.WriteLine($"{x + y}");
                Console.WriteLine($"{y - x}");
                Console.WriteLine($"{x * y}");
                Console.WriteLine("Not Allowed To divide By Zero");
            }
            #endregion
        }

    }
}