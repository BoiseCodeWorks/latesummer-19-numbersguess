using System;

namespace numberguess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Random rng = new Random();
            int magicNumber = rng.Next(1, 101);
            //System.Console.WriteLine(magicNumber);
            System.Console.WriteLine("Guess a random number between 1-100");
            bool guessing = true;
            while (guessing)
            {
                string choice = Console.ReadLine();
                if (Int32.TryParse(choice, out int guessed))
                {
                    if (guessed == magicNumber)
                    {
                        Console.WriteLine("You WIN!");
                        Console.WriteLine("Press 'A'  to play again or any other key to quit");
                        ConsoleKeyInfo again = Console.ReadKey();
                        if (again.KeyChar == 'a')
                        {
                            magicNumber = rng.Next(1, 101);
                            Console.Clear();
                            System.Console.WriteLine("Guess a random number between 1-100");
                        }
                        else
                        {
                            guessing = false;
                        }
                    }
                    else if (guessed < magicNumber)
                    {
                        Console.WriteLine("Your guess is too low dum dum! Guess again");
                    }
                    else
                    {
                        Console.WriteLine("WAY TO HIGH YOU MORON!  Guess again");
                    }
                }
                else
                {
                    System.Console.WriteLine("Do you not know what a number is?");
                }
            }

        }
    }
}
