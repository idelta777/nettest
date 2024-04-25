using Microsoft.AspNetCore.Mvc;

namespace WebApplication1;

public class KVController : Controller
{
    private readonly IConfiguration _configuration;
    
    public KVController(IConfiguration configuration)
    {
        this._configuration = configuration;
    }
    // GET
    public IActionResult Index()
    {
        return Ok(Convert.ToString(_configuration["testsecret"]));
    }
}