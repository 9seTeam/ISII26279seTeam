namespace AppForSEII.API.Models;


public class LineaReserva
{
    public LineaReserva()
    {
    }

    public LineaReserva(TiempoReserva tiempoReserva, decimal precioSubtotal)
    {
        TiempoReserva = tiempoReserva;  
        PrecioSubtotal = precioSubtotal;
    }

    public int Id { get; set; }
    public TiempoReserva TiempoReserva { get; set; }
    public decimal PrecioSubtotal { get; set; }
   
}