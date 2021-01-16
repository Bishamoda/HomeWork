using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Сейчас будут целые числа");
            byte BytePer1 = 255;
            Console.WriteLine("Это переменная типа байт - от 0 до 255: {0}", BytePer1);

            short ShortPer1 = 100;
            Console.WriteLine("Короткое число: {0}", ShortPer1);

            int IntPer1 = 20000;
            Console.WriteLine("Это целое число: {0}", IntPer1);

            long LongPer1 = 10000000000;
            Console.WriteLine("Это длинное число: {0}\n", LongPer1);


            Console.WriteLine("А теперь числа с плавающей запятой");
            float FloatPer1 = 2.1F;
            Console.WriteLine("Это число с плавающей запятой одиночной точности: {0}", FloatPer1);

            double DoublePer1 = 10.10202001;
            Console.WriteLine("Это число с плавающей запятой двойной точности: {0}", DoublePer1);

            decimal DecimalPer1 = 1000.10299991391M;
            Console.WriteLine("Оень точное число, для точных вычислений: {0}\n", DecimalPer1);

            Console.WriteLine("А как же текст?");
            Char CharPer1 = 'M';
            string StringPer1 = "А тут уже целый текст :)";

            Console.WriteLine("Вот это символ: {0}", CharPer1);
            Console.WriteLine("Вот это строка: {0}\n", StringPer1);



            Console.WriteLine("А теперь немного алгебры логики");
            bool Yes = true;
            bool No = false;

            Console.WriteLine("Таблица истиннсоти И: \n" + "false false = {0}\n" + "false true или true false = {1}\n" + "true true = {2}\n", No && No, No && Yes, Yes && Yes);
            Console.WriteLine("Таблица истиннсоти ИЛИ: \n" + "false false = {0}\n" + "false true или true false = {1}\n" + "true true = {2}\n", No || No, No || Yes, Yes || Yes);
            Console.WriteLine("Таблица истиннсоти НЕ: \n" + "Отрицание false = {0}\n" + "Отрицание true = {1}\n", !No, !Yes);

            bool Example1 = !(No&&Yes)||(Yes&&Yes)||(No||No);
            Console.WriteLine("Пример1. НЕ(false И true) ИЛИ (true И true) ИЛИ (false ИЛИ false)\n" + "Результат: {0}", Example1);

            bool Example2 = !((No && Yes) || !(Yes && Yes));
            Console.WriteLine("Пример2. НЕ((false И true) ИЛИ НЕ(true И true))\n" + "Результат: {0}", Example2);

            bool Example3 = ((No && Yes) || !(Yes && Yes));
            Console.WriteLine("Пример3. Тот же, но без общего отрицания. (false И true) ИЛИ НЕ(true И true)\n" + "Результат: {0}", Example3);

        }
    }
}
