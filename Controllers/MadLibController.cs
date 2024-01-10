using DresselZFivetoSevenEndpoints.Services.MadLib;
using Microsoft.AspNetCore.Mvc;

namespace DresselZFivetoSevenEndpoints.Controllers;

[ApiController]
[Route("MadLib")]
public class MadLibController : ControllerBase
{
    private readonly IMadLibService _madlibService;

    public MadLibController(IMadLibService madLibService)
    {
        _madlibService = madLibService;
    }

    [HttpGet]
    [Route("Mad")]
    public string MadLib(string string1, string string2, string string3)
    {
        return _madlibService.MadLib(string1, string2, string3);
    }
}
