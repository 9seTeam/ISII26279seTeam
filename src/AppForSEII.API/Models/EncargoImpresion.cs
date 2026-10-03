namespace AppForSEII.API.Models;

public class EncargoImpresion
{
    public EncargoImpresion()
    {
    }

    public EncargoImpresion(DateTime fechaEncargo, string nombreCliente, string apellidosCliente, string direccionEnvio, string numeroTelefono, string descripcion, decimal precioTotal, MetodoPago metodoPago)
    {
        FechaEncargo = fechaEncargo;
        NombreCliente = nombreCliente;
        ApellidosCliente = apellidosCliente;
        DireccionEnvio = direccionEnvio;
        NumeroTelefono = numeroTelefono;
        Descripcion = descripcion;
        PrecioTotal = precioTotal;
        MetodoPago = metodoPago;
    }
    [Key]
    public int Id { get; set; }
    public DateTime FechaEncargo { get; set; }
    [Required, MaxLength(20)]
    public string NombreCliente { get; set; }
    [Required, MaxLength(50)]
    public string ApellidosCliente { get; set; }
    [Required, MaxLength(100)]
    public string DireccionEnvio { get; set; }
    [Required, MaxLength(20)]
    public string NumeroTelefono { get; set; }
    public string? Descripcion { get; set; }
    public decimal PrecioTotal { get; set; }
    [Required, MaxLength(20)]
    public MetodoPago MetodoPago { get; set; }
}