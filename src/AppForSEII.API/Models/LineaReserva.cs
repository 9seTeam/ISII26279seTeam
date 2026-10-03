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
    public TiempoReserva TiempoReserva { get; set; }
    public decimal PrecioSubtotal { get; set; }

    public int ReservaImpresoraId { get; set; }
    public ReservaImpresora ReservaImpresora { get; set; }

    public int ImpresoraId { get; set; }
    public Impresora3D Impresora { get; set; }  
   
}