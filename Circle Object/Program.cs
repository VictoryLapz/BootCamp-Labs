/*
Objectives: Objects, Methods, Member Variables

Task: Calculate a circle’s diameter, circumference and area.

What will the application do?
The application prompts the user to enter a radius; the user may enter a number with decimals (double).
The application displays an error if the user enters invalid data and asks the user again for a radius.
When the user enters valid data, the application creates an instance of a Circle and then uses its methods to display the Diameter, Circumference and Area.
The application asks the user if the circle should grow.
If the user says yes, call the grow method and then loop back to the method calls for the formulas. 
The grow method will adjust radius to double its value.
If the user says no, the application displays a “goodbye” message that also displays the radius of the circle.

Build Specifications:
Create a class named Circle to store the data about this circle. This class should contain these constructors and methods:
Properties
private double radius
Constructor
public Circle(double radius)
Methods
public double CalculateDiameter()
public double CalculateCircumference()
public double CalculateArea()
public void Grow()
public double GetRadius()

For the value of pi, use the PI constant of the System.Math class.
Get the user input, create a Circle object, and display the diameter, circumference and area.

 */

using Circle_Object;
using System.Security.Cryptography.X509Certificates;


Console.WriteLine("Please enter a radius?");
double userinput = Convert.ToDouble(Console.ReadLine());

if (userinput <= 0)
{
    Console.WriteLine("Error!... Please RE-enter a radius?");
}

else
{
    Circle circle = new Circle(userinput);
    Console.WriteLine($"Diameter: {circle.CalculatedDiameter()}");
    Console.WriteLine($"Circumference: {circle.CalculateCircumference()}");
    Console.WriteLine($"Area: {circle.CalculateArea()}");
}


Console.WriteLine("Would you like the Circle to Grow (Y/N)?");
string userAnswer = Console.ReadLine().ToUpperInvariant();

if (userAnswer != "Y")
{
    Circle circle = new Circle(userinput);

    Console.WriteLine($"Goodbye! Final radius: {circle.CalculatedDiameter() / 2}");
}
else
{
    Circle circle = new Circle(userinput);
    circle.Grow();
    Console.WriteLine("Circle is growing!");
    Console.WriteLine($"Diameter: {circle.CalculatedDiameter()}");
    Console.WriteLine($"Circumference: {circle.CalculateCircumference()}");
    Console.WriteLine($"Area: {circle.CalculateArea()}");
}
