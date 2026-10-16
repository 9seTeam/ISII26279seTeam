using AppForSEII.API.DTOs;

namespace AppForSEII.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ModelosController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly ILogger<ModelosController> _logger;

    public ModelosController(ApplicationDbContext context, ILogger<ModelosController> logger)
    {
        _context = context;
        _logger = logger;
    }

    [HttpGet]
    [Route("[action]")]
    [ProducesResponseType(typeof(IList<ModeloParaComprarDTO>), (int)HttpStatusCode.OK)]
    [ProducesResponseType(typeof(ValidationProblemDetails), (int)HttpStatusCode.BadRequest)]
    public async Task<ActionResult> GetModelosParaComprar(string? nombre, string? categoria)
    {
        IList<ModeloParaComprarDTO> modelos = await _context.Modelos3Ds
            .Where(m => (nombre == null || m.Nombre.Contains(nombre))
                && (categoria == null || m.Categoria == categoria))
            .OrderBy(m => m.Nombre)
            .Select(m => new ModeloParaComprarDTO(m.Id, m.Nombre, m.Categoria,
                m.Licencia.Nombre, m.Formato.ToString(), m.Precio))
            .ToListAsync();

        return Ok(modelos);
    }
}