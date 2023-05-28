using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число: ");
            int userNumber = int.Parse(Console.ReadLine());

            if (userNumber % 2 == 0)
            {
                Console.WriteLine("Введенное число четное");
            }
            else Console.WriteLine("Введенное число нечетное");

            Console.ReadLine();
        }
    }
}
