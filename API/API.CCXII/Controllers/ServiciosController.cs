using Microsoft.AspNetCore.Mvc;

namespace API.CCXII.Controllers;

[ApiController]
[Route("api/v1/servicios")]
public class ServiciosController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok();
    }
}
