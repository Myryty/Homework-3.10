using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Привет, игрок! Сколько карт у вас на руках?: ");
            int counter = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= counter; i++)
            {
                Console.Write($"Значение карты номер {i}: ");
                string handWeight = Console.ReadLine();

                switch (handWeight)
                {
                    case "2":
                        sum += 2;
                        break;
                    case "3":
                        sum += 3;
                        break;
                    case "4":
                        sum += 4;
                        break;
                    case "5":
                        sum += 5;
                        break;
                    case "6":
                        sum += 6;
                        break;
                    case "7":
                        sum += 7;
                        break;
                    case "8":
                        sum += 8;
                        break;
                    case "9":
                        sum += 9;
                        break;
                    case "10":
                    case "J":
                    case "Q":
                    case "K":
                    case "T":
                        sum += 10;
                        break;
                    default:
                        Console.WriteLine("Разрешено вводить 2-10, J, Q, K, T");
                        i--;
                        break;
                }

            }

            Console.WriteLine($"Сумма карт: {sum}");
            Console.ReadLine();
        }
    }
}
