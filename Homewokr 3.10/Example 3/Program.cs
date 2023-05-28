using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число: ");
            int userN = int.Parse(Console.ReadLine());
            bool primeN = true;
            int i = 2;

            while (i <= userN - 1)
            {

                if (userN % i == 0)
                {
                    primeN = false;
                    break;
                }
                i++;
            }
            if (primeN)
            {
                Console.WriteLine($"Введенное число {userN} является простым");
            }
            else
            {
                Console.WriteLine($"Введенное число {userN} не является простым");
            }
            Console.ReadLine();
        }
    }
}
