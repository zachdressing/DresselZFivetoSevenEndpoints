using DresselZFivetoSevenEndpoints.Services.OddorEven;
using Microsoft.AspNetCore.Mvc;

namespace DresselZFivetoSevenEndpoints.Controllers;

[ApiController]
[Route("OddorEven")]
public class OddorEvenController : ControllerBase
{
    private readonly IOddorEvenService _oddorevenService;

    public OddorEvenController(IOddorEvenService oddorEvenService)
    {
        _oddorevenService = oddorEvenService;
    }

    [HttpGet]
    [Route("OddEven")]
    public string OddorEven(int num1)
    {
        return _oddorevenService.OddorEven(num1);
    }
}
