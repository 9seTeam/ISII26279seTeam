using AppForSEII.API.DTOs;

namespace AppForSEII.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AccesoriosController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly ILogger<AccesoriosController> _logger;

    public AccesoriosController(ApplicationDbContext context, ILogger<AccesoriosController> logger)
    {
        _context = context;
        _logger = logger;
    }

    [HttpGet]
    [Route("[action]")]
    [ProducesResponseType(typeof(IList<AccesorioParaComprarDTO>), (int)HttpStatusCode.OK)]
    [ProducesResponseType(typeof(ValidationProblemDetails), (int)HttpStatusCode.BadRequest)]
    public async Task<ActionResult> GetAccesoriosParaComprar(string? nombre, CategoriaAccesorio? categoria)
    {
        IList<AccesorioParaComprarDTO> accesorios = await _context.Accesorios
            .Where(a => a.CantidadDisponible > 0
                && (nombre == null || a.Nombre.Contains(nombre))
                && (categoria == null || a.Categoria == categoria))
            .OrderBy(a => a.Nombre)
            .Select(a => new AccesorioParaComprarDTO(a.Id, a.Nombre, a.Categoria.ToString(),
                a.Compatibilidad, a.CantidadDisponible, a.Precio))
            .ToListAsync();

        return Ok(accesorios);
    }
}