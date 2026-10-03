namespace AppForSEII.API.Models;

public class LineaEncargo
{
    public LineaEncargo()
    {
    }

    public LineaEncargo(int cantidad, decimal precioUnidad, decimal subtotal)
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

     public int EncargoImpresionId { get; set; }
    public EncargoImpresion EncargoImpresion { get; set; }

    public int PiezaId { get; set; }
    public Pieza3D Pieza { get; set; }
    
    public int MaterialSeleccionadoId { get; set; }
    public Material MaterialSeleccionado { get; set; }
}