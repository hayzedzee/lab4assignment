using System;

namespace Lab4work
{
    class Program
    {
        static void Main(string[] args)
        {
         int a = 0, b = 0;
            Console.WriteLine(" This App will return true if the sum of both numbers is less than 100. Otherwise return false.");

            Console.WriteLine("Enter the first Number: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second Number: ");
            b = Convert.ToInt32(Console.ReadLine());

            int d = a + b;

            if (d < 100)
            {

                bool c = true;
                Console.WriteLine(c);
            }
            else
            {
                bool c = false;
                Console.WriteLine(c);
            }

        }
    }
}
