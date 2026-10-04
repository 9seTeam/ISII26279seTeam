namespace AppForSEII.API.Models;

public class Modelo3D
{
    public Modelo3D()
    {
    }

    public Modelo3D(string nombre, string categoria, FormatoModelo3D formato, decimal precio)
    {
        Nombre = nombre;
        Categoria = categoria;
        Formato = formato;
        Precio = precio;
    }

    [Key]
    public int Id { get; set; }

    [MaxLength(30)]
    public string Nombre { get; set; } 
    
    [MaxLength(30)]
    public string Categoria { get; set; } 
    public FormatoModelo3D Formato { get; set; }
    public decimal Precio { get; set; }

}