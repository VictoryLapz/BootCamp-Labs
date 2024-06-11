namespace Circle_Object;

public class Circle
{
    private double radius;

    public Circle(double radius) 
    {  
        this.radius = radius;
    }

    public double CalculatedDiameter()
    {
        return 2 * radius;
    }

    public double CalculateCircumference()
    {
        return 2 * Math.PI * radius;
    }
    public double CalculateArea() 
    {  
        return Math.PI * radius * radius;
    }

    public void Grow()
    {
        radius *= radius;
    }
     public double GetRadius()
    {
        return CalculatedDiameter() / 2;
    }


}
