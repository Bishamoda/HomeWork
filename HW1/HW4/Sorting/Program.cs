using System;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b, n;
           
            Console.WriteLine("Выберите длину массива: ");
            
            n = Console.ReadLine();
            int k = int.Parse(n);

            Console.WriteLine("Выберите интервал чисел: ");
            
            a = Console.ReadLine();
            b = Console.ReadLine();

            int x = int.Parse(a);
            int y = int.Parse(b);

            Random rnd = new Random();
            int[] mass = new int[k];

            Console.WriteLine("Такой массив: ");
            for(int i = 0; i < k; i++)
            {
                mass[i] = rnd.Next(x, y);
                Console.Write(" " + mass[i]);
            }

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

            Console.WriteLine(Environment.NewLine + "Теперь он выглядит так: ");
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write(" " + mass[i]);
            }

            Console.ReadKey();
        }
    }
}
