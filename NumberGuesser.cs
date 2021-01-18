using System;


//Namespace
namespace NumberGuesser
{
    //Main Class
    class Program
    {
        //Entry point method
        static void Main(string[] args)
        {
            //Practice area
            string name = "Gilbert Lowrey";
            int age = 34;
            Console.WriteLine("Hello World");
            Console.WriteLine("What up you beautiful blueberry spinning through space?!");
            Console.WriteLine("Hello there " + name + " you can do this C# stuff. It's a little like JavaScript.");
            Console.WriteLine("{0} you are doing pretty well for being {1} years old.", name, age);
            //Application begins
            //Set app variables

            //Run GetAppInfo to get app infor
            GetAppInfo();

            GreetUser(); //Ask for user name

            while (true)
            {
                //init correct number
                //int correctNumber = 7;

                //create as new random object
                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                //Init guess var
                int guess = 0;

                //Asking for user guess
                Console.WriteLine("Guess a number between 1 and 10.");

                //what to do when they guess wrong
                while (guess != correctNumber)
                {
                    //get input from user
                    string input = Console.ReadLine();

                    //Make sure input is number
                    if (!int.TryParse(input, out guess))
                    {
                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please a real number");
                        //keep going
                        continue;
                    }

                    //cast to int and put in guess
                    guess = Int32.Parse(input);

                    //Match guess to correct number
                    if (guess != correctNumber)
                    {
                        //Error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number buddy.");

                    }
                }
                //output success message
                PrintColorMessage(ConsoleColor.Green, "You did it!! That was the correct number.");


                //Ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                //Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }
        //Get and display app info
        static void GetAppInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Gil Lowrey with help from Brad Traversy";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Blue;

            //Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Resets color
            Console.ResetColor();
        }


        //greet and get name
        static void GreetUser()
        {
            //Ask for name
            Console.WriteLine("What is your name?");

            //Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game!", inputName);
        }

        //Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            //Change text color
            Console.ForegroundColor = color;

            //message given to user
            Console.WriteLine(message);

            //Resets color
            Console.ResetColor();
        }

    }
}
