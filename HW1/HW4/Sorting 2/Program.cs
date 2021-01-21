using System;

namespace Sorting_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Укажите размер массива: ");
            int k = int.Parse(Console.ReadLine());

            int[] mass = new int[k];

            Random rnd = new Random();

            Console.WriteLine("Сейчас он выглядит так: ");
            WriteMass(k, mass, rnd);
 
            Console.WriteLine(Environment.NewLine + "Теперь он выглядит так: ");
            SortingMass(mass);

            ViewMass(mass);

        }

        private static void WriteMass(int k, int[] mass, Random rnd)
        {
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rnd.Next(0, k);
                Console.Write(" " + mass[i]);
            }
        }

        public static void SortingMass(int[] mass)
        {
            int c;
            for (int i = 0; i < mass.Length - 1; i++)
            {
                for (int j = i + 1; j < mass.Length; j++)
                {
                    if (mass[i] > mass[j])
                    {
                        c = mass[i];
                        mass[i] = mass[j];
                        mass[j] = c;
                        
                    } 
                }
            }

        }

        public static void ViewMass(int[] mass)
        {
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write(" " + mass[i]);
            }
        }
    }
}
