namespace AppForSEII.API.DTOs;
public class CompraAccesoriosItemDTO
{
    public CompraAccesoriosItemDTO(int accesorioId, string nombre, CategoriaAccesorio categoria,
        string compatibilidad, int cantidad, decimal precioUnidad)
    {
        AccesorioId = accesorioId;
        Nombre = nombre;
        Categoria = categoria;
        Compatibilidad = compatibilidad;
        Cantidad = cantidad;
        PrecioUnidad = precioUnidad;
    }

    public int AccesorioId { get; set; }

    public string Nombre { get; set; }

    public CategoriaAccesorio Categoria { get; set; }

    public string Compatibilidad { get; set; }

    public int Cantidad { get; set; }

    public decimal PrecioUnidad { get; set; }

    public decimal Subtotal
    {
        get
        {
            return Cantidad * PrecioUnidad;
        }
    }

    public override bool Equals(object? obj)
    {
        return obj is CompraAccesoriosItemDTO dto &&
               AccesorioId == dto.AccesorioId &&
               Nombre == dto.Nombre &&
               Categoria == dto.Categoria &&
               Compatibilidad == dto.Compatibilidad &&
               Cantidad == dto.Cantidad &&
               PrecioUnidad == dto.PrecioUnidad;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(AccesorioId, Nombre, Categoria, Compatibilidad, Cantidad, PrecioUnidad);
    }
}
