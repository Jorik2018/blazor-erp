using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using blazor_erp.Data;

namespace blazor_erp.Controllers;

[Route("specials")]
[ApiController]
public class SpecialsController : ControllerBase
{
    private readonly PizzaStoreContext _db;

    public SpecialsController(PizzaStoreContext db)
    {
        _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<List<PizzaSpecial>>> GetSpecials()
    {
        return (await _db.Specials.ToListAsync()).OrderByDescending(s => s.BasePrice).ToList();
    }
}