using System;

namespace Справочник
{
    class Program
    {
        static void Main(string[] args)
        {
            string ages;
            bool result;

            string[] names = new string[8];
            names[0] = "Mihail ";
            names[1] = "Alex ";
            names[2] = "Pavel ";
            names[3] = "Roma ";
            names[4] = "Andrey ";

            byte[] age = new byte[8];
            age[0] = 22;
            age[1] = 28;
            age[2] = 30;
            age[3] = 25;
            age[4] = 16;

            string[] phoneNumber = new string[8];
            phoneNumber[0] = " 8(906)-321-45-12";
            phoneNumber[1] = " 8(906)-321-45-34";
            phoneNumber[2] = " 8(906)-321-45-56";
            phoneNumber[3] = " 8(906)-321-45-78";
            phoneNumber[4] = " 8(906)-321-45-90";

            Console.WriteLine("Сейчас таблица пользователей такая: \n" +
                "Имя  Возраст  Телефон");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    Console.Write("{0} ", names[i]);
                    Console.Write(" {0} ", age[i]);
                    Console.Write(" {0}", phoneNumber[i]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Добавьте трех новых пользователей");
            for (int i = 5; i < names.Length; i++)
            {
                Console.WriteLine("Введите имя: ");
                names[i] = Console.ReadLine();

                Console.WriteLine("Введите возраст: ");
                ages = Console.ReadLine();
                result = byte.TryParse(ages, out byte ageRes);
                if (result == true)
                {
                    age[i] = ageRes;
                } else
                {
                    Console.WriteLine("Неверные данные");
                    break;
                }

                Console.WriteLine("Введите номер телефона: ");
                phoneNumber[i] = Console.ReadLine();

            }

            Console.WriteLine("Теперь таблица пользователей такая: \n" +
                "Имя  Возраст  Телефон");

            for (int i = 0; i < names.Length; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    Console.Write("{0} ", names[i]);
                    Console.Write(" {0} ", age[i]);
                    Console.Write(" {0}", phoneNumber[i]);
                }
                Console.WriteLine();
            }

        }
    }
}
