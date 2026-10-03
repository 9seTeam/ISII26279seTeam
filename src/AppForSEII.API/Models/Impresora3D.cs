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

    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Modelo { get; set; } = string.Empty;
    public TipoImpresora Tipo { get; set; }
    public string Descripcion { get; set; } = string.Empty;
    public decimal PrecioKilovatioHora { get; set; }
    public decimal PrecioReserva { get; set; }
}