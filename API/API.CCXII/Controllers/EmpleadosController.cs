using Microsoft.AspNetCore.Mvc;

namespace API.CCXII.Controllers;

[ApiController]
[Route("api/v1/empleados")]
public class EmpleadosController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok();
    }
}
