using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the guessing game");
            Console.WriteLine();
            Console.WriteLine("Enter 1 if you would like to guess my number or 2 if you would like me to guess your number");
            int game = int.Parse(Console.ReadLine());
            if (game == 1)
                userGuess();
            else if (game == 2)
                compGuess();
            else
                throw new FormatException();
        }
        static void userGuess()
        {
            Random rndm = new Random();
            int rn = rndm.Next(00, 100);
           // Console.WriteLine(rn);
            int g = 0; //guess
            int count = 0;
            Console.WriteLine("I have chosen a number between 1 and 100.");
            Console.WriteLine("See if you can guess it in 7 or less guesses");
            while (g != rn)
            {
                g = Convert.ToInt32(Console.ReadLine());
                count++;
                if (g < rn)
                    Console.WriteLine("Too Low. guess again");
                else if (g > rn)
                    Console.WriteLine("Too High. Guess again");
                else
                    Console.WriteLine($"You guessed Correct. it took you {count} guesses");
            }

        }
        static void compGuess()
        {
            int minNumber = 1;
            int maxNumber = 100;

            Console.WriteLine($"What is your number between {minNumber} and {maxNumber}?");
            int numGiven = Convert.ToInt32(Console.ReadLine());
            int count = 1;
            int guess = (maxNumber + minNumber) / 2;
            Console.WriteLine($"Is the number: {guess}");

            if (numGiven == guess)
            {
                Console.WriteLine($"I guessed your number {guess} in {count} guess");
            }
            else
            {
                while (guess != numGiven)
                {
                    count++;

                    //Number is greater
                    if (numGiven > guess)
                    {
                        Console.WriteLine("Too low, guess higher!");
                        minNumber = guess;
                        guess = (maxNumber + minNumber) / 2;

                    }
                    //Number is less
                    else if (numGiven < guess)
                    {
                        Console.WriteLine("Too High, guess lower!");
                        maxNumber = guess;
                        guess = (maxNumber + minNumber) / 2;
                    }
                    //Else it equals
                    else
                    {
                        Console.WriteLine($"I guessed your number {guess} in {count} guesses.");
                    }
                    Console.WriteLine($"Is the number: {guess}");
                }
                Console.WriteLine($"I guessed the correct number: {guess} in {count} guesses");
            }
        }

    }
}
