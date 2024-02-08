namespace CMPS360Assignment4;

class Program
{
    static void Main(string[] args)
    {
  Console.WriteLine("Welcome to The House of Pain!");

            int correctGuesses = 0;
            int totalGuesses = 0;

            while (correctGuesses < 3)
            {
                // Generate Random Number
                Random random = new Random();
                int targetNumber = random.Next(1, 10);

                // Capture the attempts
                int attempts = 0;
                bool hasGuessedCorrectly = false;

                Console.WriteLine("Try to guess the number between 1 and 10");

                while (!hasGuessedCorrectly)
                {
                    Console.WriteLine("Input your guess: ");
                    string userInput = Console.ReadLine();

                    if (int.TryParse(userInput, out int userGuess))
                    {
                        attempts++;
                        totalGuesses++;
                        if (userGuess == targetNumber)
                        {
                            hasGuessedCorrectly = true;
                            correctGuesses++;
                            Console.WriteLine("Congrats you guessed it! Total correct guesses: " + correctGuesses);
                        }
                        else
                        {
                            string hint = userGuess < targetNumber ? "Too low, try again" : "Too high, try again";
                            Console.WriteLine(hint);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, please enter a valid number");
                    }
                }

                Console.WriteLine("Number of attempts for this round: " + attempts);
            }

            Console.WriteLine("Congrats you have guessed correctly 3 times and beaten The House of Pain!");
            Console.WriteLine("Total number of guesses: " + totalGuesses);
            Console.WriteLine("Thank you for playing The House of Pain");
        }
    }
