using AppForSEII.API.DTOs;

namespace AppForSEII.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ReservarController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly ILogger<ReservarController> _logger;

    public ReservarController(ApplicationDbContext context, ILogger<ReservarController> logger)
    {
        _context = context;
        _logger = logger;
    }

     [HttpGet]
    [Route("[action]")]
    [ProducesResponseType(typeof(IList<ImpresoraParaReservarDTO>), (int)HttpStatusCode.OK)]
    [ProducesResponseType(typeof(ValidationProblemDetails), (int)HttpStatusCode.BadRequest)]
    public async Task<ActionResult> GetImpresorasParaReservar(string? nombre, TipoImpresora? tipo)
    {
        IList<ImpresoraParaReservarDTO> impresoras = await _context.Impresoras3Ds
            .Where(i => (nombre == null || i.Nombre.Contains(nombre))
                && (tipo == null || i.Tipo == tipo))
            .OrderBy(i => i.Nombre)
            .Select(i => new ImpresoraParaReservarDTO(i.Id, i.Nombre, i.Modelo, i.Tipo.ToString(),
                i.Descripcion, i.PrecioKilovatioHora, i.PrecioReserva))
            .ToListAsync();

        if (!impresoras.Any())
            _logger.LogWarning("No hay impresoras disponibles para reservar.");

        return Ok(impresoras);
    }

    
}