namespace Roshambo;

public abstract class Player
{
    public Roshambo Value { get; set; }

    public abstract Roshambo GenerateRoshambo();
    
    public Player(Roshambo value)
    {  this.Value = value; 
    }
}
