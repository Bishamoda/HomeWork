using System;

namespace Lesson_5
{

    class Program
    {
        
        static void Main(string[] args)
        {
            //Printer.Print("Test value");

            Person person = new Person();
            //person.SetName("Misha");
            person.Name = "Mihail";
            person.Age = 19;
            Console.WriteLine(person.GetInfo());


            Person person2 = new Person();
            //person2.SetName("Pasha");
            person2.Age = 17;
            Console.WriteLine(person2.Age);
        }
    }
}
