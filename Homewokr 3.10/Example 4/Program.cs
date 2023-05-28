using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите длинну последовательности: ");
            int lengthN = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите числа: ");
            int smallestN = int.MaxValue;

            for (int i = 1; i <= lengthN; i++)
            {
                Console.Write("     ");
                int userN = int.Parse(Console.ReadLine());


                if (userN < smallestN)
                {
                    smallestN = userN;
                }

            }
            Console.WriteLine($"Наименьшее число в последовательности: {smallestN}");
            Console.ReadLine();
        }
    }
}
