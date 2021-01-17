using System;

namespace Калькулятор
{
    class Program
    {
        static void Main(string[] args)
        {
            string number1;
            string number2;
            string operation;
            double c;
            bool succes1;
            bool succes2;


            do
            {
                Console.WriteLine("Введите два числа. Не целые числа записывайте через запятую! ");

                number1 = Console.ReadLine();
                number2 = Console.ReadLine();
                

                succes1 = double.TryParse(number1, out double a);
                succes2 = double.TryParse(number2, out double b);

                if ((succes1 && succes2) == true)
                {
                    Console.WriteLine("Ваши числа: {0}, {1}", a, b);


                    Console.WriteLine("Выберите операцию: сложение +, вычитание  -, умножение *, деление / ");
                    operation = Console.ReadLine();

                    switch (operation)
                    {
                        case "+":
                            c = a + b;
                            Console.WriteLine("Результат: {0} + {1} = {2}\n", a, b, c);
                            break;

                        case "-":
                            c = a - b;
                            Console.WriteLine("Результат: {0} - {1} = {2}\n", a, b, c);
                            break;

                        case "*":
                            c = a * b;
                            Console.WriteLine("Результат: {0} * {1} = {2}\n", a, b, c);
                            break;

                        case "/":
                            if (b != 0)
                            {
                                c = a / b;
                                Console.WriteLine("Результат: {0} / {1} = {2}\n", a, b, c);
                            }
                            else
                            {
                                Console.WriteLine("Не ну Вы серьезно?");
                            }
                            break;

                        default:
                            Console.WriteLine("Ну и ладно!");
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("Вы ввели не число!");
                }

            } while ((succes1 && succes2) == true);



        }
    }
}
