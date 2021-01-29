using System;
using System.Collections.Generic;
using System.Text;

namespace Spravochnik_Lesson5
{
    public class Person
    {
        private string _name;
        private byte _age;
        private long _phone;

        public Person() { }
        public Person(string name, byte age, long phone)
        {

            this._name = name;
            this._age = age;
            this._phone = phone;

        }

        public void Display()
        {
           string age = Convert.ToString(_age);
           string phone = Convert.ToString(_phone);

           Console.WriteLine("{0} {1} {2}", _name, age, phone);
        }

        public void AddPerson()
        {
            Console.WriteLine("Введите имя: ");
            _name = Console.ReadLine();
            
            Console.WriteLine("Введите возраст: ");
            _age = Byte.Parse(Console.ReadLine());

            Console.WriteLine("Введите номер телефона: ");
            _phone = Int64.Parse(Console.ReadLine());

        }
    }
}
