
using System.Reflection.Metadata;

Console.WriteLine("Welcome to Roshambo! Please enter username?");
string username = Console.ReadLine();

Console.WriteLine("Please select Rock, Paper, or Scissors?");
string selection = Console.ReadLine();


int result = -1;
Console.WriteLine("Enter a number");
while (int.TryParse(Console.ReadLine(), out result) == false)
{
    Console.WriteLine("Invalid. Try again");
}