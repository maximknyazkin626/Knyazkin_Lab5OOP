using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Knyazkin_Lab5OOP
{
    class Program
    {
        static void printMenu()
        {
            Console.WriteLine("1. Add player.");
            Console.WriteLine("2. Add coach.");
            Console.WriteLine("3. Show all.");
            Console.WriteLine("4. Load all.");
            Console.WriteLine("5. Save all.");
            Console.WriteLine("6. Clear.");
            Console.WriteLine("0. Exit.");
            Console.WriteLine("Choose action: ");
        }
        static void Main(string[] args)
        {
            Knyazkin_team team = new Knyazkin_team();

            while (true)
            {
                printMenu();
                int menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case (1):
                        team.addPlayer();
                        break;
                    case (2):
                        team.addCoach();
                        break;
                    case (3):
                        team.printAll();
                        break;
                    case (4):
                        team.loadAll();
                        break;
                    case (5):
                        team.saveAll();
                        break;
                    case (6):
                        team.clearAll();
                        break;
                    case (0):
                        return;
                    default:
                        break;

                }
            }

        }
    }
}