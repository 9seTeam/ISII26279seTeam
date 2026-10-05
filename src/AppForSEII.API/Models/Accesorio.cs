namespace AppForSEII.API.Models;

public class Accesorio
{
    public Accesorio()
    {
    }

    public Accesorio (string nombre, CategoriaAccesorio categoria, string compatibilidad,
        int cantidadDisponible, decimal precio)
    {
        Nombre = nombre;
        Categoria = categoria;
        Compatibilidad = compatibilidad;
        CantidadDisponible = cantidadDisponible;
        Precio = precio;
    }
    [Key]
    public int Id { get; set; }
    [MaxLength(30)]
    public string Nombre { get; set; }
    public CategoriaAccesorio Categoria { get; set; }
    [MaxLength(10)]
    public string Compatibilidad { get; set; }
    public int CantidadDisponible { get; set; }
    [Precision(8, 2)]
    public decimal Precio { get; set; }

}