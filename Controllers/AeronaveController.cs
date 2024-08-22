using AirlinesControl.Services;
using AirlinesControl.ViewModels.Aircraft;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace AirlinesControl.Controllers;

[Route("api/aeronaves")]
[ApiController] // Informa que o retorno é JSON e não views
public class AeronaveController(AeronaveService aeronaveService) : ControllerBase
{
    private readonly AeronaveService _aeronaveService = aeronaveService;

    [HttpPost]
    public IActionResult AdicionarAeronave(AdicionarAeronaveViewModel dados)
    {
        var aeronave = _aeronaveService.AdicionarAeronave(dados);
        return Ok(aeronave);
    }
}
