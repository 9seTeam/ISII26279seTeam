namespace AppForSEII.API.Models;


public class LineaReserva
{
    public LineaReserva()
    {
    }

    public LineaReserva(int id, TiempoReserva tiempoReserva, decimal precioSubtotal)
    {
        Id = id;
        TiempoReserva = tiempoReserva;
        PrecioSubtotal = precioSubtotal;
    }

    public int Id { get; set; }
    public TiempoReserva tiempoReserva { get; set; }
    public decimal PrecioSubtotal { get; set; }
   
}