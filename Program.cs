using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        public static bool continue_run()
        {

            Console.Write("Roll again?(Y/N) : ");
            string response = Console.ReadLine();
            response = response.ToLower();
            if (response == "y")
            {
                return true;
            }
            else if (response == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("You did not type a recognized caracter, type Y or N");

                return continue_run();
            }

        }
        static void Main(string[] args)
        {
            int increment = 1;
            Console.WriteLine("Welcome to DiceRollerApp");
            Console.Write("How many sides should each dice have?: ");
            int side = int.Parse(Console.ReadLine());
            Console.WriteLine();
            bool run = true;
            Random r = new Random();
            int die1, die2;
            while (run)
            {
                die1 = r.Next(1, side + 1);
                die2 = r.Next(1, side + 1);
                Console.WriteLine("Roll " + increment++);
                Console.WriteLine(die1);
                Console.WriteLine(die2);
                run = continue_run();
                Console.WriteLine();
            }




            // Console.ReadLine();
        }
    }
}
