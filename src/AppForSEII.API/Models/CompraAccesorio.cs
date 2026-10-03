namespace AppForSEII.API.Models;

public class CompraAccesorios
{
    public CompraAccesorios()
    {
    }

    public CompraAccesorios(string nombreCliente, string apellidosCliente, string direccionEnvio,
        string numeroTelefono, MetodoPago metodoPago)
    {
        FechaCompra = DateTime.Now;
        NombreCliente = nombreCliente;
        ApellidosCliente = apellidosCliente;
        DireccionEnvio = direccionEnvio;
        NumeroTelefono = numeroTelefono;
        MetodoPago = metodoPago;
    }
    [Key]
    public int Id { get; set; }
    public DateTime FechaCompra { get; set; }
    [MaxLength(30)]
    public string NombreCliente { get; set; } 
    [MaxLength(30)]
    public string ApellidosCliente { get; set; } 
    [MaxLength(50)]
    public string DireccionEnvio { get; set; } 
    [MaxLength(10)]
    public string NumeroTelefono { get; set; } 
    public decimal PrecioTotal { get; set; }
    public MetodoPago MetodoPago { get; set; }

    public string ClienteId { get; set; }
    public Cliente Cliente { get; set; }

    public List<LineaCompraAccesorio> Lineas { get; set; } = new();
   
}
