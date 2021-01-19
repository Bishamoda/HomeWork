using System;

namespace Калькулятор_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string number1;
            string number2;
            string operation;
            bool succes1;
            bool succes2;

            do
            {
                Console.WriteLine("Ну давайте считать!\n" + "Введите два числа:");
                number1 = Console.ReadLine();
                number2 = Console.ReadLine();

                succes1 = double.TryParse(number1, out double a);
                succes2 = double.TryParse(number2, out double b);

                if ((succes1 && succes2) == true)
                {
                    Console.WriteLine("Ваши числа: " + a + " " + b);
                    Console.WriteLine("Выберите операцию: + , - , * , / ");

                    operation = Console.ReadLine();
                    switch (operation)
                    {
                        case "+":
                            Console.WriteLine(Sum(a, b));
                            break;

                        case "-":
                            Console.WriteLine(Sub(a, b));
                            break;

                        case "*":
                            Console.WriteLine(Mul(a, b));
                            break;

                        case "/":
                            Console.WriteLine(Div(a, b));
                            break;

                        default:
                            Console.WriteLine("Такой операции нет!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Вы ввели не число!");
                }

            } while ((succes1 && succes2) == true);
        }

        public static double Sum(double a, double b)
        {
            double result;
            result = a + b;
            return result;
        }

        public static double Sub(double a, double b)
        {
            double result;
            result = a - b;
            return result;
        }

        public static double Mul(double a, double b)
        {
            double result;
            result = a * b;
            return result;
        }
        public static double Div(double a, double b)
        {
            double result;
            if (b != 0)
            {
                result = a / b;
                return result;
            }
            else
            {
                return -1;
            }
    
        }
    }
}
