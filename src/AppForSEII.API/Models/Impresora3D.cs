namespace AppForSEII.API.Models;

public class Impresora3D
{

    public Impresora3D()
    {
    }

    public Impresora3D(string nombre, string modelo, TipoImpresora tipo, string descripcion,
        decimal precioKilovatioHora, decimal precioReserva)
    {
        Nombre = nombre;
        Modelo = modelo;
        Tipo = tipo;
        Descripcion = descripcion;
        PrecioKilovatioHora = precioKilovatioHora;
        PrecioReserva = precioReserva;
    }

    [Key]
    public int Id { get; set; }
    [MaxLength(20)]
    public string Nombre { get; set; } 
    [MaxLength(50)]
    public string Modelo { get; set; }
    public TipoImpresora Tipo { get; set; }
    [MaxLength(200)]
    public string Descripcion { get; set; }
    [Precision(8, 2)]
    public decimal PrecioKilovatioHora { get; set; }
    [Precision(8, 2)]
    public decimal PrecioReserva { get; set; }
}