namespace AppForSEII.API.Models;

public class CompraModelo3D
{
    public CompraModelo3D()
    {
    }

    public CompraModelo3D(string nombreCliente, string apellidosCliente, string correoElectronico,
        string direccionFacturacion, string? descripcion, MetodoPago metodoPago)
    {
        FechaCompra = DateTime.Now;
        NombreCliente = nombreCliente;
        ApellidosCliente = apellidosCliente;
        CorreoElectronico = correoElectronico;
        DireccionFacturacion = direccionFacturacion;
        Descripcion = descripcion;
        MetodoPago = metodoPago;
    }

    [Key]
    public int Id { get; set; }
    public DateTime FechaCompra { get; set; }

    [Required][MaxLength(30)]
    public string NombreCliente { get; set; }

    [Required][MaxLength(30)]
    public string ApellidosCliente { get; set; }

    [MaxLength(30)]
    public string CorreoElectronico { get; set; }

    [Required][MaxLength(30)]
    public string DireccionFacturacion { get; set; }

    [MaxLength(50)]
    public string? Descripcion { get; set; }
    public decimal PrecioTotal { get; set; }

    [Required]
    public MetodoPago MetodoPago { get; set; }

    public string ClienteId { get; set; } = string.Empty;
    public Cliente? Cliente { get; set; }

}