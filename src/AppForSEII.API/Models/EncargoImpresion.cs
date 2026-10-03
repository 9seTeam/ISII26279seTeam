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

    public int Id { get; set; }
    public DateTime FechaEncargo { get; set; }
    public string NombreCliente { get; set; }
    public string ApellidosCliente { get; set; }
    public string DireccionEnvio { get; set; }
    public string NumeroTelefono { get; set; }
    public string? Descripcion { get; set; }
    public decimal PrecioTotal { get; set; }
    public MetodoPago MetodoPago { get; set; }
}