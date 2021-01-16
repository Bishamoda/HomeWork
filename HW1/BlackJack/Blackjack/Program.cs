using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            bool isPlayerContinue = true;
            bool isComputerContinue = true;

            Random random = new Random();

            do
            {
                Console.WriteLine("Будешь тянуть карту? (y/n)");
                string answer = Console.ReadLine();

                if (answer == "y")
                {
                    Console.WriteLine("Вы тяните");
                }

                if (answer == "n")
                {
                    Console.WriteLine("Вы пасcуете");
                    isPlayerContinue = false;
                }

                int decisionNumber = 0;

                if (isComputerContinue)
                {
                    decisionNumber = random.Next(0, 2);
                }

                if (decisionNumber == 0)
                {
                    Console.WriteLine("Компьютер тянете карту");
                }

                if (decisionNumber == 1)
                {
                    Console.WriteLine("Компьютер пассуете");
                    isPlayerContinue = false;
                }
            } while (isPlayerContinue);

            

            Console.ReadKey();
        }
    }
}
