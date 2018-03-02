using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichaelaMurray_27011537_Exwk1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Michaela-Emily Murray");
            
            int num1 = (12);
            int num2 = (34);

            Console.WriteLine();
            Console.WriteLine(num1 + num2);

            int num3 = (100);
            int num4 = (5);

            Console.WriteLine();
            Console.WriteLine(num3 / num4);

            Console.WriteLine();
            Console.WriteLine("Input First Number:");
            int num5 = (int.Parse(Console.ReadLine()));
            Console.WriteLine("Input Second Number");
            int num6 = (int.Parse(Console.ReadLine()));
            int result = num5 * num6;
            Console.WriteLine(result);

            Console.WriteLine();
            Console.WriteLine("Please Input Number:");
            int num7 = (int.Parse(Console.ReadLine()));
            for (int i = 1; i <= 10; i++)
            {
                int ans = i * num7;
                Console.WriteLine(ans);
            }

            Console.WriteLine();
            double rad = (7.5);
            double peri = 2 * 3.14 * rad;
            double area = 3.14 * rad * rad;
            Console.WriteLine(peri);
            Console.WriteLine(area);

            Console.WriteLine();
            Console.WriteLine("Please Input Number:");
            int num = (int.Parse(Console.ReadLine()));

            if (num > 0)
            {
                Console.WriteLine("The Number is Positive");

            }
            else
            {
                Console.WriteLine("The Number is Negative");
            }

            Console.ReadKey();
        }
    }
}
