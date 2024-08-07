namespace Adoption_MVC.Models;

public class Animal
{

    public int AnimalId { get; set; }

    public string Name { get; set; }
    public string Breed { get; set; }
    public string Description { get; set; }

    public string ImgName { get; set; }

    public int Age { get; set; }

    public bool IsAdopted {  get; set; }
}
