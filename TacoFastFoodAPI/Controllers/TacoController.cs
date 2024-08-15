using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using TacoFastFoodAPI.Models;
using Tacos.Data;


namespace TacoFastFoodAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TacoController : ControllerBase
{
    //start DI
    private readonly FastFoodTacoDbContext _fastFoodTacoDB;

    public TacoController(FastFoodTacoDbContext fastFoodTacoDbContext)
    {
        _fastFoodTacoDB = fastFoodTacoDbContext;
    }
    //END DI

    [HttpGet]
    public IActionResult GetAllTacos([FromQuery] bool? SoftShell)
    {

        if (SoftShell != null)
        {
            var taco = _fastFoodTacoDB.Taco.Where(t => t.SoftShell == SoftShell.Value).ToList();
            return Ok(taco);
        }
        return Ok(_fastFoodTacoDB.Taco.ToList());
    }

    [HttpGet("{id}")]

    public IActionResult GetTacosById(int Id)
    {
     var taco = _fastFoodTacoDB.Taco.Find(Id);

        if (taco == null)
        {
            return NotFound();
    }
        return Ok(taco);
    }

[HttpPost]

public IActionResult CreateTaco([FromBody] Taco taco)
{
        if (taco == null)
        {
            return NotFound();
        }

        var NewTacos = new Taco
        {

        Id = taco.Id,
        Name = taco.Name,
        Cost = taco.Cost,
        SoftShell = taco.SoftShell,
        Chips = taco.Chips
        };
        try
        {
            _fastFoodTacoDB.Taco.Add(taco);
            _fastFoodTacoDB.SaveChanges();
        }
        catch (Exception ex)
        {
            // Log the exception (ex) here
            return StatusCode(500, "Internal server error");
        }

        return CreatedAtAction(nameof(GetTacosById), new { id = taco.Id }, taco);

}

[HttpDelete("{id}")]
public IActionResult DeleteTaco(int id)
{
    var taco = _fastFoodTacoDB.Taco.Find(id);

    if (taco == null)
    {
        return NotFound();
    }

    _fastFoodTacoDB.Taco.Remove(taco);
    _fastFoodTacoDB.SaveChanges();

    return NoContent();
        }
    }

