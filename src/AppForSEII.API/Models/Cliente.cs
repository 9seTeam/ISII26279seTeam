namespace AppForSEII.API.Models;
public class Cliente : ApplicationUser
{
    public Cliente()
    {
        
    }
    public Cliente (string id, string nombre, string apellidos, string nombreUsuario, string direccionFac)
    {
        DireccionFacturacion = direccionFac;
    }

    public string? DireccionFacturacion {get;set;}
}