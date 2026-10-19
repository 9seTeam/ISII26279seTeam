namespace AppForSEII.API.DTOs
{
    public class AccesorioParaComprarDTO
    {
    public AccesorioParaComprarDTO()
    {
    }

    public AccesorioParaComprarDTO(int id, string nombre, string categoria,
        string compatibilidad, int cantidadDisponible, decimal precio)
    {
        Id = id;
        Nombre = nombre;
        Categoria = categoria;
        Compatibilidad = compatibilidad;
        CantidadDisponible = cantidadDisponible;
        Precio = precio;
    }

    public int Id { get; set; }

    [StringLength(30, ErrorMessage = "Nombre cannot be longer than 30 characters.")]
    public string Nombre { get; set; } = string.Empty;

    public string Categoria { get; set; } = string.Empty;

    [StringLength(10, ErrorMessage = "Compatibilidad cannot be longer than 10 characters.")]
    public string Compatibilidad { get; set; } = string.Empty;
    public int CantidadDisponible { get; set; }

    public decimal Precio { get; set; }

    public override bool Equals(object? obj)
    {
        return obj is AccesorioParaComprarDTO dto &&
               Id == dto.Id &&
               Nombre == dto.Nombre &&
               Categoria == dto.Categoria &&
               Compatibilidad == dto.Compatibilidad &&
               CantidadDisponible == dto.CantidadDisponible &&
               Precio == dto.Precio;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id, Nombre, Categoria, Compatibilidad, CantidadDisponible, Precio);
    }
    
    } 
}