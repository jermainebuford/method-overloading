using System;

namespace method_overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine( Add(4, 2));
            Console.WriteLine( Add(5.5m, 3.6m));
            Add(6, 7, true);
        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2; 
        }
        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
        public static string Add(int num1, int num2, bool isTrue)
        {
            var sum = 0;

            if(isTrue)
            {
                sum = num1 + num2;

                if (sum == 1)
                {
                    Console.WriteLine($"{sum} dollar");
                }
                else
                {
                    Console.WriteLine($"{sum} dollars");
                }
              
            }
            return "not a correct entry";
        }
    }
}
