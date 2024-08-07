using Adoption_MVC.Data;
using Adoption_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Adoption_MVC.Controllers;

public class AnimalController : Controller
{
    //Dependency Injection
    private readonly AppDbContext _dbContext;
    //makes a private copy of DB

    public AnimalController(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    [HttpPost]

    public IActionResult Result(AnimalType animalType)
    {
        return View(animalType);
    }


    public IActionResult SearchAnimals(string breedInput)
    {

        var animals = _dbContext.Animals.Where(x => x.Breed == breedInput).ToList();
        return View(animals);
    }

    public IActionResult Add(Animal animals)
    {
        return View(View(animals));
    }
}
