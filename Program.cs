using System;

namespace GuessingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(); // Random object to create a random number. 
            bool playAgain = true;
            int min = 1;
            int max = 100;

            int guess; // you can assign a variable but they dont need to have anything them.
            int number;
            int guesses;
            String response;

            while(playAgain) // this by itself is like while(playAgain == true)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(min, max + 1); // the max + 1 is because that number is exculsive  

                while(guess != number)
                {
                    Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);
                    if (guess > number)
                    {
                        Console.WriteLine(guess + " is to high!");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " is to low!");

                    }
                    guesses++;
                }
                Console.WriteLine("Number: " + number);
                Console.WriteLine("You WIN!");
                Console.WriteLine("Guesses: " + guesses);

                Console.WriteLine("Would you like to play again?(Y/N)");
                response = Console.ReadLine();
                response = response.ToUpper();
                if (response == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }
            Console.WriteLine("Thanks for playing! . . . I guess");
            Console.ReadKey();
        }
    }
}
