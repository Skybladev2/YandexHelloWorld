using Microsoft.AspNetCore.Mvc;

namespace YandexHelloWorld.Controllers;

[ApiController]
[Route("")]
public class HelloController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        return "Hello";
    }
}

