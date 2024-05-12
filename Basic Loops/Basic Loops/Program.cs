
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

while(true)
{ 
    Console.WriteLine("Hello World!");
    string answer = "Y";
    Console.WriteLine("Would you like to continue?(Y/N)");
    answer = Console.ReadLine().ToUpper();
    if (answer != "Y")
    {
        Console.WriteLine("GoodBye!");
        break;
    }
}
//
//Counter
//
{
    Console.WriteLine("Please enter a number:");
}
int number = int.Parse(Console.ReadLine());
Console.WriteLine();

for (int i = number; i >= 0; i--)

{
    Console.WriteLine($"{i}");
    
}

for (int i = 0; i <= number; i++)

{
    Console.WriteLine($"{i}");
};

//
//Entery Code
//
bool AccessCode = true;

while (AccessCode)
{
    Console.WriteLine("Please Enter Key Code?");
    string codeEntered = Console.ReadLine();
    

    if (codeEntered == "13579")
    {
        Console.WriteLine("Access Granted?");
        AccessCode = false;
    }
}

Console.WriteLine();
bool NextAccessCode = true;
int TryAgain = 0;

while (NextAccessCode)
{
    Console.WriteLine("HaHa Now please enter the next Key Code?");
    string codeEntered = Console.ReadLine();
    TryAgain++;

    if (codeEntered == "13579")
    {
        Console.WriteLine("Okay You Win! Access Granted!");
        NextAccessCode = false;
    }
    if (TryAgain > 4 && codeEntered != "13579")
    {
        Console.WriteLine("Warning there were too many incorrect attempts");
        break;
    }
}


