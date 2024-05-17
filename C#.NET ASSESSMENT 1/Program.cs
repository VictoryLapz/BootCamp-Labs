

//static method name IsPassing that returns Bool and takes in grades(dobule)
using System.ComponentModel.Design;
using System.Runtime.ConstrainedExecution;

static bool IsPassing(double num1)
{
    if (num1 >= 66) return true;
    else
    {
        return false;
    }
    
}
Console.WriteLine(IsPassing(50));

static double AverageGrade(double grade1, double grade2, double grade3)
{
    double sum = grade1 + grade2 + grade3;
    return sum / 3;
}
{
    double grade1 = 80;
    double grade2 = 70;
    double grade3 = 65;
    double Average = AverageGrade(grade1, grade2, grade3);
    Console.WriteLine(Average);
}  


static string OddOrEvenAndPassing(double num1)
{
    int finalgrade = (int)Math.Round(num1);

    if (finalgrade % 2 != 0 && num1 >= 66)
    {
        return "passing and odd.";
    }
    else if (finalgrade % 2 != 0 && num1 <= 65)
    {
        return "failing and odd.";
    }
    else if (finalgrade % 2 == 0 && num1 >= 66)
    {
        return "passing and even.";
    }
    else
    {
        return "failing and even.";
    }
}


