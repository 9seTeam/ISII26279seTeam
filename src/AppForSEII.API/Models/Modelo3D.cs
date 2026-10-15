namespace AppForSEII.API.Models;

public class Modelo3D
{
    public Modelo3D()
    {
    }

    public Modelo3D(string nombre, string categoria, FormatoModelo3D formato, decimal precio, LicenciaModelo3D licencia)
    {
        Nombre = nombre;
        Categoria = categoria;
        Formato = formato;
        Precio = precio;
        Licencia = licencia;
    }

    [Key]
    public int Id { get; set; }

    [MaxLength(30)]
    public string Nombre { get; set; } 
    
    [MaxLength(30)]
    public string Categoria { get; set; } 
    public FormatoModelo3D Formato { get; set; }
    [Precision(8, 2)]
    public decimal Precio { get; set; }

    public int LicenciaModelo3DId { get; set; }

    public LicenciaModelo3D Licencia { get; set; }

}