// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;


Console.WriteLine("Please enter a number?");
int numberpicked = int.Parse(Console.ReadLine());
  
int sum = 0;
for (int a = 1; a <= numberpicked; a++) 
{ 
    sum += a;
}
{
    Console.WriteLine($"The total sum equals {sum}");
}