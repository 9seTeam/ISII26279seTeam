namespace AppForSEII.API.Models;

public class Material
{
    public Material()
    {
    }

    public Material(string nombre, decimal precioPorGramo, decimal stockGramos)
    {
        Nombre = nombre;
        PrecioPorGramo = precioPorGramo;
        StockGramos = stockGramos;
    }

    [Key]
    public int Id { get; set; }

    [MaxLength(30)]
    public string Nombre { get; set; } = string.Empty;

    public decimal PrecioPorGramo { get; set; }
    public decimal StockGramos { get; set; }
}