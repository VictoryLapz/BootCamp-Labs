namespace Cars_and_Used_Cars;

public abstract class Car
{
    ///Parameters
    public string Make {  get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public decimal Price { get; set; }

    //Constructors
    public Car(string Make, string Model, int Year, decimal Price)
    {
        this.Make = Make;
        this.Model = Model;
        this.Year = Year;
        this.Price = Price;
    }

    //Methods
    public override string ToString()
    {
        return $"{Make},{Model},{Year}-{Price}";
    }
}
