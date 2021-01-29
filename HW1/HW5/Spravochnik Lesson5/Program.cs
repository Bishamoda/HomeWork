using System;

namespace Spravochnik_Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Имя " + " Возраст " + "Телефон ");

            Person person1 = new Person("Mihail", 22, 89036775979);
            Person person2 = new Person("Alex", 29, 89036775978);
            Person person3 = new Person("Roman", 26, 89036775977);

            person1.Display();
            person2.Display();
            person3.Display();

            Console.WriteLine(Environment.NewLine + "Добавьте, пожалуйста, двух новых пользователей.");

            Person person4 = new Person();
            person4.AddPerson();

            Person person5 = new Person();
            person5.AddPerson();

            Console.WriteLine(Environment.NewLine + "Имя " + " Возраст " + "Телефон ");
            person1.Display();
            person2.Display();
            person3.Display();
            person4.Display();
            person5.Display();
           
        }
                


    }
}
