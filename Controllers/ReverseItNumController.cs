using Microsoft.AspNetCore.Mvc;
using DresselZFivetoSevenEndpoints.Services.ReverseItNum;

namespace DresselZFivetoSevenEndpoints.Controllers;

[ApiController]
[Route("ReverseItNum")]
public class ReverseItNumController : ControllerBase
{
    private readonly IReverseItNumService _reverseitnumService;

    public ReverseItNumController(IReverseItNumService reverseItNumService)
    {
        _reverseitnumService = reverseItNumService;
    }

    [HttpGet]
    [Route("ReverseNum")]
    public string ReverseItNum(int num1)
    {
        return _reverseitnumService.ReverseItNum(num1);
    }
}
