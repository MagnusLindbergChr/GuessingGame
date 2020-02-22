using System;

namespace GuessingGame
{
    class Program
    {
        const int maxTries = 3;

        static void Main(string[] args)
        {
            string[] names = { "Simon", "Nils", "Nicklas", "Frederik", "Anders", "Rasmus" };

            Console.WriteLine("Can you guess which word i am thinking of? is it ");
            for(int i = 0; i < names.Length; i++)
            {
                if (i == (names.Length - 1))
                    Console.WriteLine("or" + names[i] + "? ");
                else
                    Console.WriteLine(names[i] + ", ");
            }
        }
    }
}
