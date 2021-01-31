using System;

namespace Lesson_5
{
    //класс описыввать внутри класса не надо, описываем класс внутри пространства имен
    public static class Printer
    {
        public static void Print(string value)
        {
            Console.WriteLine(value);
        }
    }
}
