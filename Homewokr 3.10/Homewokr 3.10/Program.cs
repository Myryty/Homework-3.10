using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homewokr_3._10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Example 1


            // Console.Write("Введите целое число: ");
            // int userNumber = int.Parse(Console.ReadLine());

            //if (userNumber % 2 == 0)
            // {
            //     Console.WriteLine("Введенное число четное");
            // }
            // else Console.WriteLine("Введенное число нечетное");

            // Console.ReadLine();





            //Example 2


            //Console.Write("Привет, игрок! Сколько карт у вас на руках?: ");
            //int counter = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;

            //for (int i = 1; i <= counter; i++)
            //{
            //    Console.Write($"Значение карты номер {i}: ");
            //    string handWeight = Console.ReadLine();

            //    switch (handWeight)
            //    {
            //        case "2":
            //            sum += 2;
            //            break;
            //        case "3":
            //            sum += 3;
            //            break;
            //        case "4":
            //            sum += 4;
            //            break;
            //        case "5":
            //            sum += 5;
            //            break;
            //        case "6":
            //            sum += 6;
            //            break;
            //        case "7":
            //            sum += 7;
            //            break;
            //        case "8":
            //            sum += 8;
            //            break;
            //        case "9":
            //            sum += 9;
            //            break;
            //        case "10":
            //        case "J":
            //        case "Q":
            //        case "K":
            //        case "T":
            //            sum += 10;
            //            break;
            //        default:
            //            Console.WriteLine("Разрешено вводить 2-10, J, Q, K, T");
            //            i--;
            //            break;
            //    }

            //}

            //Console.WriteLine($"Сумма карт: {sum}");
            //Console.ReadLine();

            




            //Example 3 (через цикл WHILE)


            //Console.Write("Введите целое число: ");
            //int userN = int.Parse(Console.ReadLine());
            //bool primeN = true;
            //int i = 2;

            //while (i <= userN - 1)
            //{

            //    if (userN % i == 0)
            //    {
            //        primeN = false;
            //        break;
            //    }
            //    i++;
            //}
            //if (primeN)
            //{
            //    Console.WriteLine($"Введенное число {userN} является простым");
            //}
            //else
            //{
            //    Console.WriteLine($"Введенное число {userN} не является простым");
            //}
            //Console.ReadLine();








            //Example 4 (готово)


            //Console.Write("Введите длинну последовательности: ");
            //    int lengthN = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите числа: ");
            //int smallestN=int.MaxValue;

            //for (int i = 1; i <= lengthN; i++)
            //{
            //    Console.Write("     ");
            //    int userN = int.Parse(Console.ReadLine());


            //    if (userN < smallestN) 
            //    {
            //        smallestN = userN;
            //    }

            //}
            //Console.WriteLine($"Наименьшее число в последовательности: {smallestN}");
            //Console.ReadLine();






            //Example 5 (готово)


            //Console.Write("Введите максимальное целое число диапазона: ");
            //int maxValue = int.Parse(Console.ReadLine());

            //Random r = new Random();
            //int randomN = r.Next(0, maxValue + 1);
            //string empty;

            //Console.WriteLine("Введите число, если хотите завершить, то Enter ");

            //while (true)
            //{


            //    empty = Console.ReadLine();

            //    if (empty==string.Empty) 
            //    {
            //        Console.WriteLine($"Загаданное число было {randomN}");
            //        break;
            //    }
            //    int userN = int.Parse(empty);

            //    if (randomN < userN)
            //    {
            //        Console.WriteLine("Введенное число больше загаданного. Попробуйте еще!");
            //    }
            //    else if (randomN > userN)
            //    {
            //        Console.WriteLine("Введенное число меньше загаданного. Попробуйте еще!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Поздравляю! Число угаданно!");
            //        Console.ReadKey();
            //        break;
            //    }
            //}
            //Console.ReadKey();



        }
    }
}
