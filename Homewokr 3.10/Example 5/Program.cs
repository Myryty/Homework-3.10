using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите максимальное целое число диапазона: ");
            int maxValue = int.Parse(Console.ReadLine());

            Random r = new Random();
            int randomN = r.Next(0, maxValue + 1);
            string empty;

            Console.WriteLine("Введите число, если хотите завершить, то Enter ");

            while (true)
            {


                empty = Console.ReadLine();

                if (empty == string.Empty)
                {
                    Console.WriteLine($"Загаданное число было {randomN}");
                    break;
                }
                int userN = int.Parse(empty);

                if (randomN < userN)
                {
                    Console.WriteLine("Введенное число больше загаданного. Попробуйте еще!");
                }
                else if (randomN > userN)
                {
                    Console.WriteLine("Введенное число меньше загаданного. Попробуйте еще!");
                }
                else
                {
                    Console.WriteLine("Поздравляю! Число угаданно!");
                    Console.ReadKey();
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
