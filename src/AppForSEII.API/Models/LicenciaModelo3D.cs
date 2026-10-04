namespace AppForSEII.API.Models;

public class LicenciaModelo3D
{
    public LicenciaModelo3D()
    {
    }

    public LicenciaModelo3D(string nombre, DateTime fechaExpiracion)
    {
        Nombre = nombre;
        FechaExpiracion = fechaExpiracion;
    }

    [Key]
    public int Id { get; set; }
    
    [MaxLength(30)]
    public string Nombre { get; set; }
    public DateTime FechaExpiracion { get; set; }
}