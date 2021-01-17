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
            byte bytePer1 = 255;
            Console.WriteLine("Это переменная типа байт - от 0 до 255: {0}", bytePer1);

            short shortPer1 = 100;
            Console.WriteLine("Короткое число: {0}", shortPer1);

            int intPer1 = 20000;
            Console.WriteLine("Это целое число: {0}", intPer1);

            long longPer1 = 10000000000;
            Console.WriteLine("Это длинное число: {0}\n", longPer1);


            Console.WriteLine("А теперь числа с плавающей запятой");
            float floatPer1 = 2.1F;
            Console.WriteLine("Это число с плавающей запятой одиночной точности: {0}", floatPer1);

            double doublePer1 = 10.10202001;
            Console.WriteLine("Это число с плавающей запятой двойной точности: {0}", doublePer1);

            decimal decimalPer1 = 1000.10299991391M;
            Console.WriteLine("Оень точное число, для точных вычислений: {0}\n", decimalPer1);

            Console.WriteLine("А как же текст?");
            Char charPer1 = 'M';
            string stringPer1 = "А тут уже целый текст :)";

            Console.WriteLine("Вот это символ: {0}", charPer1);
            Console.WriteLine("Вот это строка: {0}\n", stringPer1);



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
