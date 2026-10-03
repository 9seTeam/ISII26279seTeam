namespace AppForSEII.API.Models;

public class ReservaImpresora
{
    public ReservaImpresora()
    {
    }

    public ReservaImpresora(DateTime fechaReserva, string nombreCliente, string apellidosCliente, string direccionFacturacion,
        decimal precioTotal,MetodoPago metodoPago)
    {
        FechaReserva = fechaReserva;
        NombreCliente = nombreCliente;
        ApellidosCliente = apellidosCliente;
        DireccionFacturacion = direccionFacturacion;
        PrecioTotal = precioTotal;
        Metodo = metodoPago;
    }

    [Key]
    public int Id { get; set; }
    public DateTime FechaReserva { get; set; }
    [Required, MaxLength(20)]
    public string NombreCliente { get; set; }
    [Required, MaxLength(50)]
    public string ApellidosCliente { get; set; } 
    [Required, MaxLength(100)]
    public string DireccionFacturacion { get; set; } 
    public decimal PrecioTotal { get; set; }
    [Required]
    public MetodoPago Metodo { get; set; }

    public string ClienteId { get; set; }
    public Cliente Cliente { get; set; }

    public List<LineaReserva> Lineas { get; set; } = new();
   
}