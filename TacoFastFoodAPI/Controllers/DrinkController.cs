using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TacoFastFoodAPI.Models;
using Tacos.Data;

namespace TacoFastFoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrinkController : ControllerBase
    {
        //start DI
        private readonly FastFoodTacoDbContext _fastFoodTacoDB;

        public DrinkController(FastFoodTacoDbContext fastFoodTacoDbContext)
        {
            _fastFoodTacoDB = fastFoodTacoDbContext;
        }
        //END DI


        [HttpGet]
        public IActionResult GetAllDrinks()
        {

         return Ok(_fastFoodTacoDB.Drink.ToList());
        }

        [HttpGet("{Id}")]

        public IActionResult GetDrinksById(int Id)
        {
            var drink = _fastFoodTacoDB.Drink.Find(Id);

            if (drink == null)
            {
                return NotFound();
            }
            return Ok(drink);
        }

        [HttpPost]

        public IActionResult CreateDrink([FromBody] Drink drink)
        {

            if (drink == null)
            {
                return NotFound();
            }

            var NewDrink = new Drink
            {

                Id = drink.Id,
                Name = drink.Name,
                Cost = drink.Cost,
                Slushie = drink.Slushie,
               
            };
           
                _fastFoodTacoDB.Drink.Add(drink);
                _fastFoodTacoDB.SaveChanges();
          
            return CreatedAtAction(nameof(GetDrinksById), new { id = drink.Id }, drink);
        }

        [HttpPut("{Id}")]
        public IActionResult UpdateDrink(int Id, [FromBody] Drink drink)
        {
            //does the recipe even exist:
            var ExisitingDrink = _fastFoodTacoDB.Drink.Find(Id);

            if (ExisitingDrink == null)
            {
                return NotFound();
            }

            ExisitingDrink.Name = drink.Name;
            ExisitingDrink.Id = drink.Id;
            ExisitingDrink.Cost = drink.Cost;
            ExisitingDrink.Slushie = drink.Slushie;

            _fastFoodTacoDB.Update(ExisitingDrink);
            _fastFoodTacoDB.SaveChanges();

            return Ok(ExisitingDrink);
        }
    }

}
