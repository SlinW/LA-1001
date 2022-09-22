using System;



namespace Numberguessinggame

{

    class Program

    {

        static void Main(string[] args)

        {

            Random random = new Random();

            bool playAgain = true;

            int min = 1;

            int max = 100;

            int number;

            int guess;

            int guesses;

            String name;

            String response;

            System.Threading.Thread.Sleep(1000);
            Console.BackgroundColor = ConsoleColor.Green;

            Console.WriteLine("Your Game is loading... Please wait...");
            System.Threading.Thread.Sleep(1000);
            Console.BackgroundColor= ConsoleColor.Blue;
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Your Game is ready...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Please enter your Name");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Yellow;
            name = Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;

            while (playAgain) 

            {
               
                guess = 0;

                guesses = 0;

                response = "";

                number = random.Next(min, max + 1);



                while (guess != number)

                {
                    Console.WriteLine("------------------------------------------------------------------------");
                    Console.WriteLine(name + ", guess a number between " + min + " - " + max + " : ");

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
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor =ConsoleColor.Black;
                Console.WriteLine("You Win!");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("Guesses: " + guesses);



                Console.WriteLine("Would you like to play again? (Y/N): ");

                response = Console.ReadLine();

                response = response.ToUpper();
                


                if (response == "Y")

                {

                    playAgain = true;

                }

                else if (response == "N")

                {

                    playAgain = false;

                }
                Console.WriteLine("Hello " + name + " you needed " + guesses + " guesses in the last round.");
                
            }
            Console.WriteLine("====================================================================================================");
            Console.WriteLine("Thanks for playing " + name + ". I guess...");
            
        }

    }

}
