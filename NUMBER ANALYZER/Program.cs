//ask user to input number between 1-100
using System.ComponentModel.Design;
bool playagain = true;

while (true)
{ 
    Console.WriteLine("Hello User, What is your name?");
string username = Console.ReadLine();

{
    Console.WriteLine("Hello, " + username + " please enter a number between 1 - 100?");
    string numberselected = Console.ReadLine();

        int number = int.Parse(numberselected);

        if (number <= 60 && number % 2 != 0)
        {
            Console.WriteLine("Odd and less than 60.");
        }
        else if (number >= 60 && number % 2 != 0)

        {
            Console.WriteLine("Odd and greater than 60.");

        }
        else if (number >= 60 && number % 2 == 0)

        {
            Console.WriteLine("Even and greater than 60.");
        }
        else if (number >= 26 && number <= 60 && number % 2 == 0)
        {
            Console.WriteLine("Even and between 26 and 60 inclusive.");
        }
        else if (number >= 2 && number <= 24 && number % 2 == 0)
        {
            Console.WriteLine("Even and less than 25.");
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter number between 1-100");
        }
        {
            Console.WriteLine();
        }
        {
            Console.Write("Would you like to play again? Enter (Y/N?)");
            Console.WriteLine();
            string answer = Console.ReadLine();
            if (answer == "N")
                {
                playagain = false;
                break;
                }
        }
    }
}