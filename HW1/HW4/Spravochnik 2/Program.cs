using System;
using System.Text;

namespace Spravochnik_2
{
    class Program
    {
        

        static void Main(string[] args)
        {
            string[] names = new string[7];
            names[0] = "Mihail ";
            names[1] = "Alex ";
            names[2] = "Roman ";
            names[3] = "Pasha ";
            names[4] = "Stepa ";

            byte[] ages = new byte[7];
            ages[0] = 23;
            ages[1] = 28;
            ages[2] = 25;
            ages[3] = 30;
            ages[4] = 19;

            double[] phoneNumber = new double[7];
            phoneNumber[0] = 89031233210;
            phoneNumber[1] = 89031233211;
            phoneNumber[2] = 89031233212;
            phoneNumber[3] = 89031233213;
            phoneNumber[4] = 89031233214;

            WriteTable(names, ages, phoneNumber);

            AddPersons(names, ages, phoneNumber);

            ViewTable(names, ages, phoneNumber);

        }
        private static void WriteTable(string[] names, byte[] ages, double[] phoneNumber)
        {
            Console.WriteLine("Сейчас таблица пользователей такая: \n" +
                "| Имя |  Возраст |  Телефон |");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    Console.Write("{0} ", names[i]);
                    Console.Write(" {0} ", ages[i]);
                    Console.Write(" {0}", phoneNumber[i]);
                }
                Console.WriteLine();
            }
        }
        private static void AddPersons(string[] names, byte[] ages, double[] phoneNumber)
        {
            Console.WriteLine("Добавьте двух новых пользователей:");

            for (int i = 5; i < names.Length; i++)
            {
                names[i] = AddName();
                ages[i] = AddAge();
                phoneNumber[i] = AddPhone();
            }
        }

        public static string AddName()
        {
            bool success = false;
            string warning = "Ошибка!";

            Console.WriteLine("Введите имя: ");

            while (success != true)
            {  
                string addName = Console.ReadLine();

                bool result = double.TryParse(addName, out double name);
                if ((addName == " ") || (result != false))
                {
                    
                    Console.WriteLine("Неверные данные\n" + "Попробуйте снова: ");
                }
                else
                {
                    success = true;
                    return addName;
                }
            }

            return warning;
        }

        public static byte AddAge()
        {
            bool success = false;

            Console.WriteLine("Введите возраст: ");

            while (success != true)
            {
                string addAge = Console.ReadLine();
                bool result = byte.TryParse(addAge, out byte age);

                if ((result == true) && (age < 120))
                {
                    success = true;
                    return age;
                }
                else
                {
                    Console.WriteLine("Неверные данные\n" + "Попробуйте снова: ");    
                }
            }

            return 0;
        }

        public static double AddPhone()
        {
            bool success = false;

            Console.WriteLine("Введите телефон: ");

            while (success != true)
            {
                string addPhone = Console.ReadLine();
                bool result = double.TryParse(addPhone, out double phoneNumber);

                if (result == true)
                {
                    success = true;
                    return phoneNumber;
                }
                else
                {
                    Console.WriteLine("Неверные данные\n" + "Попробуйте снова: ");
                }
            }

            return 0;
        }
        private static void ViewTable(string[] names, byte[] ages, double[] phoneNumber)
        {
            Console.WriteLine("Теперь таблица пользователей такая: \n" +
                  "Имя  Возраст  Телефон");

            for (int i = 0; i < names.Length; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    Console.Write("{0} ", names[i]);
                    Console.Write(" {0} ", ages[i]);
                    Console.Write(" {0}", phoneNumber[i]);
                }
                Console.WriteLine();
            }
        }
    }
}
