using System.Collections.Generic;
using System.Linq;
using Airlines.Context;
using Microsoft.AspNetCore.Mvc;


namespace Airlines.Controllers;


[ApiController]
[Route("[controller]")]
public class AirCompaniesController: ControllerBase
{
    private readonly AirlinesContext _context;

    public AirCompaniesController(AirlinesContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IEnumerable<AirCompany> Get()
    {
        return _context.AirCompanies.ToList();
    }
        
    [HttpPost]
    public IActionResult Add([FromBody] AirCompany airCompany)
    {
        _context.AirCompanies.Add(airCompany);
        _context.SaveChanges();
        return Ok(_context.SaveChanges());
    }
}