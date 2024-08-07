using Microsoft.AspNetCore.Mvc;
using CoffeeShopRegistration.Models;
using CoffeeShopRegistration.Models.Data;

namespace CoffeeShopRegistration.Controllers;

public class UserController : Controller
{
    //Dependency Injection
    private AppDbContext _dbContext;
    private UserRegistrationService _userRegistrationService;

    public UserController(AppDbContext dbContext, UserRegistrationService userRegistrationService)
    {
        _dbContext = dbContext;
        _userRegistrationService = userRegistrationService;
    }

    public IActionResult Register()
    {
        return View();
    }

    //The user on line 16 represents the data
    //the person typed into the form
    [HttpPost]
    public IActionResult RegisterUser(User user)
    {
        _userRegistrationService.RegisterUser();
        _dbContext.Add(user);

        _dbContext.SaveChanges();

        return RedirectToAction("Index", "Home");
    }
}