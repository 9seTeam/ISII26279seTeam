namespace AppForSEII.API.Models;

public class Pieza3D
{
    public Pieza3D()
    {
    }

    public Pieza3D(string nombre, decimal peso, CategoriaPieza categoria)
    {
        Nombre = nombre;
        Peso = peso;
        Categoria = categoria;
    }

    [Key]
    public int Id { get; set; }

    [MaxLength(30)]
    public string Nombre { get; set; }

    public decimal Peso { get; set; }
    public CategoriaPieza Categoria { get; set; }

    public HashSet<Material> MaterialesValidos { get; set; } = new();
}