namespace AppForSEII.API.DTOs;
public class CompraAccesoriosDetailDTO
{
    public CompraAccesoriosDetailDTO(int id, DateTime fechaCompra, string nombreCliente,
        string apellidosCliente, string direccionEnvio, string numeroTelefono,
        MetodoPago metodoPago, IList<CompraAccesoriosItemDTO> items)
    {
        Id = id;
        FechaCompra = fechaCompra;
        NombreCliente = nombreCliente ?? throw new ArgumentNullException(nameof(nombreCliente));
        ApellidosCliente = apellidosCliente ?? throw new ArgumentNullException(nameof(apellidosCliente));
        DireccionEnvio = direccionEnvio ?? throw new ArgumentNullException(nameof(direccionEnvio));
        NumeroTelefono = numeroTelefono ?? throw new ArgumentNullException(nameof(numeroTelefono));
        MetodoPago = metodoPago;
        Items = items ?? throw new ArgumentNullException(nameof(items));
    }

    public int Id { get; set; }

    public DateTime FechaCompra { get; set; }

    public string NombreCliente { get; set; }

    public string ApellidosCliente { get; set; }

    public string DireccionEnvio { get; set; }

    public string NumeroTelefono { get; set; }

    public MetodoPago MetodoPago { get; set; }

    public IList<CompraAccesoriosItemDTO> Items { get; set; }

    public decimal PrecioTotal
    {
        get
        {
            return Items.Sum(i => i.Subtotal);
        }
    }

    private static bool CompararFecha(DateTime f1, DateTime f2)
    {
        return Math.Abs((f1 - f2).TotalMinutes) < 1;
    }

    public override bool Equals(object? obj)
    {
        return obj is CompraAccesoriosDetailDTO dto &&
               Id == dto.Id &&
               CompararFecha(FechaCompra, dto.FechaCompra) &&
               NombreCliente == dto.NombreCliente &&
               ApellidosCliente == dto.ApellidosCliente &&
               DireccionEnvio == dto.DireccionEnvio &&
               NumeroTelefono == dto.NumeroTelefono &&
               MetodoPago == dto.MetodoPago &&
               Items.SequenceEqual(dto.Items) &&
               PrecioTotal == dto.PrecioTotal;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id, NombreCliente, ApellidosCliente, DireccionEnvio, NumeroTelefono, MetodoPago);
    }
}