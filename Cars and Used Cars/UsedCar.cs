
namespace Cars_and_Used_Cars;

public class UsedCar : Car
{
    ///Parameters
    public double Mileage { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public decimal Price { get; set; }

    //Constructors
    public UsedCar(string Make, string Model, int Year, decimal Price, double Mileage) : base(Make, Model, Year, Price)
    {
        this.Mileage = Mileage;
        this.Make = Make;
        this.Model = Model;
        this.Year = Year;
        this.Price = Price;
    }

    //Methods
    public override string ToString()
    {
        return $"{Make},{Model},{Year},{Mileage}-{Price}";
    }
}
