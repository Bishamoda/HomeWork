using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //byte age = 18;

            //if (age >= 16)
            //{
            //    Console.WriteLine("ВЫ можете работать!");

            //}
            //else
            //{
            //    Console.WriteLine("Лучше еще учиться :)");
            //}

            //string productCategory = "Alcohol";
            //switch(productCategory)
            //{
            //    case "alcohol" when age >=14:
            //        Console.WriteLine("Вам еще мало лет");
            //        break;

            //    case "alcholo" when age >= 18:
            //        break;

            //    case "milk":
            //        Console.WriteLine("Купите конфеты себе :) ");
            //        break;
            //    default:
            //            Console.WriteLine("Приятной покупки!");
            //        break;


            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        console.write("[]");
            //    }
            //    console.writeline();
            //}

            //bool isBoiled = false;
            //int timer = 0;
            //while (isBoiled == false)
            //{
            //    Console.Write("O");

            //    if(timer > 10)
            //    {
            //        Console.WriteLine("X");
            //        continue;
            //    }
            //    timer++;
            //    if (timer == 20)
            //    {
            //        break;
            //    }

            //    if (timer == 15)
            //    {
            //        isBoiled = true;
            //    }

            //}

            //Console.WriteLine();
            //Console.WriteLine("Вода вскипела!");

            //bool succes = false;
            //Console.WriteLine("Введите число от 1 до 10");
            //do
            //{

            //    string answer = Console.ReadLine();

            //    succes = int.TryParse(answer, out int value);
            //    if (value >= 1 && value <= 10)
            //    {
            //        Console.WriteLine("Вы ввели: " + value);

            //    }

            //    if (!succes)
            //    {
            //        Console.WriteLine("Вы ввели не число");
            //    }

            //} while (!succes);

            //string str = "abcdefg";

            //foreach (var item in str)
            //{
            //    Console.WriteLine(item);
            //}    



            //string name = "Ivan";
            //string name1 = "Maks";
            //string name2 = "Mihail";
            //string name3 = "alexrus";

            //Console.WriteLine("Введите ваше имя:");
            //string name6 = Console.ReadLine();

            //string[] names = new string[4];
            
            //names[0] = "Ivan";
            //names[1] = "Maks";
            //names[2] = "Mihail";
            //names[3] = "alexrus";
            //Console.WriteLine("Введите имя: ");
            //Console.ReadLine();
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}

            //string[] names1 = new string [4]
            //{
            //    "Ivan",
            //    "Ivan",
            //    "Ivan",
            //    "Ivan",
            //    "Ivan",
            //    "Ivan"

            //};

            int[] numbers = new int[10];
            Random random = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next();
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }


            //Console.WriteLine(name);

            Console.ReadKey();
        }
    }
}
