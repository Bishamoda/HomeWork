using System;

namespace Lesson_4
{
    class Program
    {
        
        
            //Методы всегда отражают дейсвия
            //Поэтому названия методов - это глаголы!!!!
            //Писать модификатор доступа писать надо!
            //Public пишут вверху программы, далее пишут private меиоды

            //private static void PrintNumber(int number)
            //{
            //    Console.WriteLine(number);
            //}

            //private static void PrintNumbers(int[] numbers)
            //{
            //    for (int i = 0; i < numbers.Length; i++)
            //    {
            //        if (i == 1)
            //        {
            //            continue;
            //        }
            //        if (i > 9)
            //        {
            //            break;
            //        }
            //        Console.WriteLine(numbers[i]);
            //    }

            //}

            //private static void PrintNumbers2(params int[] numbers)
            //{
            //    for (int i = 0; i < numbers.Length; i++)
            //    {
            //        if (i == 1)
            //        {
            //            continue;
            //        }
            //        if (i > 9)
            //        {
            //            break;
            //        }
            //        Console.WriteLine(numbers[i]);
            //    }

            //}

            //private static void PrintString(string str)
            //{
            //    if (str == "" || str == null)
            //    {
            //        return;
            //    }
            //    Console.WriteLine(str);
            //}

            //in параметр используется для чистой функции, онли чтение!
            private static int Sum(ref int a, int b)
            {
                a = 10;
                int result = a + b;

                return result;
            }

            //public static float Devide(float a, float b)
            //{
            //    if (b != 0)
            //    {
            //        return a / b;
            //    }
            //    else
            //    {
            //        return 0;
            //    }

            //}
            //public static bool TryDevide(decimal a, decimal b, out decimal result)
            //{
            //    result = 0;

            //    if (b <= 0)
            //    {
            //        return false;
            //    }

            //    result = a / b;
            //    return true;

            //}

            static void Main(string[] args)
            {


            //PrintNumbers2(0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            //PrintNumbers2(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            int number = 24;
            int result = Sum(ref number, 7);
            Console.WriteLine(result);
            Console.WriteLine(number);

            number = 24;
            int result2 = Sum(ref number, 22);
            Console.WriteLine(result2);
            Console.WriteLine(number);

            //bool isSuccess = TryDevide(10, 0, out decimal result);
            //if (isSuccess)
            //{
            //    Console.WriteLine(result);
            //}

            //isSuccess = TryDevide(10, 2, out result);
            //if (isSuccess)
            //{
            //    Console.WriteLine(result);
            //}

            //string answer = Console.ReadLine();
            //bool isSuccess = int.TryParse(answer, out int number);
            //if (isSuccess)
            //{
            //    Console.WriteLine(number);
            //}
            //PrintNumber(256);
            //PrintString("Test string");
            //PrintString(null);
            //PrintString("");

            //PrintNumbers(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            //float floatResult = Devide(4, 7);
            //Console.WriteLine(floatResult);



            }
        
    }
}
