using Microsoft.AspNetCore.Mvc;
using DresselZFivetoSevenEndpoints.Services.ReverseItAlpha;

namespace DresselZFivetoSevenEndpoints.Controllers;

[ApiController]
[Route("ReverseItAlpha")]
public class ReverseItAlphaController : ControllerBase
{
    private readonly IReverseItAlphaService _reverseitaplhaService;

    public ReverseItAlphaController(IReverseItAlphaService reverseItAlphaService)
    {
        _reverseitaplhaService = reverseItAlphaService;
    }

    [HttpGet]
    [Route("ReverseAlpha")]
    public string ReverseItAlpha(string string1)
    {
        return _reverseitaplhaService.ReverseItAlpha(string1);
    }
}
