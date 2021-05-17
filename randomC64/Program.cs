using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomC64
{
    class Program
    {

        public static void Main(string[] args)
        { 
            while(true)
            {
                Console.WriteLine("Press 1 to generate random C64 game. Press 2 to exit program: ");
                string getInput = Console.ReadLine();

                switch (getInput)
                {
                    case "1":
                        Random rndInt = new Random();
                        int gameInt = rndInt.Next(1, 28500); 

                        string newGame = getGame(gameInt);
                        Console.WriteLine(newGame);
                        continue;

                    case "2":
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Please make a valid selection!");
                        continue;
                }
                break;
            }
        }
       
        public static string getGame(int randomGameToPick)
        {
            // Load C64 Game Database
            string[] c64List = File.ReadAllLines("C64GameList.txt");

            return c64List[randomGameToPick];   
        }
    }
}
