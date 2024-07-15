namespace Roshambo;
    public class RandomPlayer
{
    public Random rand = new Random();
    public Roshambo GetRandomChoice()
    {

        int randNumber = rand.Next(0, 3);
        return (Roshambo)randNumber;
    }
}
