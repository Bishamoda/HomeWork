using System;

namespace Lesson_5
{
    public class Person
    {
        public Person(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public Person(int age)
        {
            _age = age;
        }

        public Person()
        {
            
        }
        //Fields
        private string _name;
        //private static string _name;
        private int _age;

        //Properties
        public string Name { get; set; }
        public int Age { get
            { 
                return _age; 
            }
            set 
            { if (value < 18)
                {
                    _age = -1;
                }
                else
                {
                    _age = value;
                }
                
            }
        }

        public string GetInfo()
        {
            return Name + ": " + Age;
        }

        //Method
        //public string GetName()
        //{
        //    return _name;
        //}

        //public void SetName(string name)
        //{
        //    _name = name;
        //}
    }
}
