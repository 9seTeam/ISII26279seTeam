namespace AppForSEII.API.Models;

public class CompraAccesorios
{
    public CompraAccesorios()
    {
    }

    public CompraAccesorios(int id, string nombreCliente, string apellidosCliente, string direccionEnvio,
        string numeroTelefono, MetodoPago metodoPago)
    {
        Id = id;
        FechaCompra = DateTime.Now;
        NombreCliente = nombreCliente;
        ApellidosCliente = apellidosCliente;
        DireccionEnvio = direccionEnvio;
        NumeroTelefono = numeroTelefono;
        MetodoPago = metodoPago;
    }

    public int Id { get; set; }
    public DateTime FechaCompra { get; set; }
    public string NombreCliente { get; set; } = string.Empty;
    public string ApellidosCliente { get; set; } = string.Empty;
    public string DireccionEnvio { get; set; } = string.Empty;
    public string NumeroTelefono { get; set; } = string.Empty;
    public decimal PrecioTotal { get; set; }
    public MetodoPago MetodoPago { get; set; }
   
}
