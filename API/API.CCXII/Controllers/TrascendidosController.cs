using Microsoft.AspNetCore.Mvc;

namespace API.CCXII.Controllers;

[ApiController]
[Route("api/v1/trascendidos")]
public class TrascendidosController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok();
    }
}
