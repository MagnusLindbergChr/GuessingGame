using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {

        static void Main(string[] args)
        {
            int Trials = 0;
            int MaxTrials = 3;
            bool OutOfTrials = false;
            string[] Names = { "Simon", "Nils", "Nicklas", "Frederik", "Anders", "Rasmus" };
            string UserGuess = "";
            Random RandomNumber = new Random();
            int Target = RandomNumber.Next(Names.Length);

            Console.WriteLine("Can you guess which word i am thinking of? is it ");
            for(int i = 0; i < Names.Length; i++)
            {
                if (i == (Names.Length - 1))
                    Console.WriteLine("or" + Names[i] + "? ");
                else
                    Console.WriteLine(Names[i] + ", ");
            }

            while(UserGuess != Names[Target] && !OutOfTrials)
            {
                if (Trials < MaxTrials)
                {
                    Console.WriteLine("Enter Guess: ");
                    UserGuess = Console.ReadLine();
                    Console.WriteLine("Not the right guess, try again!");
                    Trials++;
                }
                else
                {
                    OutOfTrials = true;
                    Console.WriteLine("Sorry! You didn't guess the word");
                    Console.WriteLine("You lose");
                    Console.WriteLine("Press enter to exit");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }

            if (UserGuess == Names[Target])
            {
                Console.WriteLine("Congratulations! You guessed the name!");
                Console.WriteLine("What a time to be alive!");
            }

            /*
            if (UserTry == Names[Target])
            {
                Console.WriteLine("Congratulations! You guessed the name");
                Console.WriteLine("What a day to be alive!");
            }
            else if (UserTry != Names[Target] && Trials < 3)
            {
                Console.WriteLine("Sorry, that is not the word i'm looking for");
                Trials++;
                Console.WriteLine("Try again!");
            } */

            Console.ReadLine();

        }
    }
}
