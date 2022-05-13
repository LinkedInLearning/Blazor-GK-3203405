using Microsoft.AspNetCore.Mvc;
using BlazorWasmApp1.Shared;

namespace BlazorWasmApp1.Server.Controllers;

[ApiController]
[Route("[controller]")]
public class VersionController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        return Environment.Version.ToString();
    }
}
