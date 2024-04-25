using Microsoft.AspNetCore.Mvc;

namespace WebApplication1;

[Route("api/[controller]")]
[ApiController]
public class HelloController : ControllerBase
{
    private readonly IConfiguration _configuration;

    public HelloController(IConfiguration configuration)
    {
        this._configuration = configuration;
    }

    [HttpGet]
    public IActionResult GetSecret()
    {
        return Ok(Convert.ToString(_configuration["testsecret"]));
    }
}