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

    public int Id { get; set; }
    public DateTime FechaReserva { get; set; }
    public string NombreCliente { get; set; }
    public string ApellidosCliente { get; set; } 
    public string DireccionFacturacion { get; set; } 
    public decimal PrecioTotal { get; set; }
    public MetodoPago Metodo { get; set; }
   
}