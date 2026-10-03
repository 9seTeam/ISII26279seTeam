namespace AppForSEII.API.Models;

public class LineaCompraAccesorio
{
    public LineaCompraAccesorio()
    {
    }

    public LineaCompraAccesorio(int cantidad, decimal precioUnidad, decimal subtotal)
    {
        Cantidad = cantidad;
        PrecioUnidad = precioUnidad;
        Subtotal = subtotal;
    }
    [Key]
    public int Id { get; set; }
    public int Cantidad { get; set; }
    public decimal PrecioUnidad { get; set; }
    public decimal Subtotal { get; set; }

    public int CompraAccesoriosId { get; set; }
    public CompraAccesorios CompraAccesorios { get; set; }

    public int AccesorioId { get; set; }
    public Accesorio Accesorio { get; set; }
}