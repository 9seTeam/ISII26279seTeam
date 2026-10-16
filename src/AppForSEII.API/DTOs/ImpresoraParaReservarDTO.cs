namespace AppForSEII.API.DTOs
{
    public class ImpresoraParaReservarDTO
    {
        public ImpresoraParaReservarDTO()
        {
        }
        public ImpresoraParaReservarDTO(int id, string nombre, string modelo, string tipo, string descripcion, decimal precioKwh, decimal precioReserva)
        {
            Id = id;
            Nombre = nombre;
            Modelo = modelo;
            Tipo = tipo;
            Descripcion = descripcion;
            PrecioKwh = precioKwh;
            PrecioReserva = precioReserva;
        }
    public int Id { get; set; }

    [StringLength(50, ErrorMessage = "El nombre no puede tener más de 50 caracteres.")]
    public string Nombre { get; set; }

    [StringLength(50, ErrorMessage = "El modelo no puede tener más de 50 caracteres.")]
    public string Modelo { get; set; }

    [StringLength(15, ErrorMessage = "El tipo no puede tener más de 15 caracteres.")]
    public string Tipo { get; set; } // Filamento, Resina, Polímero

    [StringLength(500, ErrorMessage = "La descripción no puede tener más de 500 caracteres.")]
    public string Descripcion { get; set; }

    public decimal PrecioKwh { get; set; }
    public decimal PrecioReserva { get; set; }
    

    public override bool Equals(object obj)
    {
        return obj is ImpresoraParaReservarDTO dto &&
               Id == dto.Id &&
               Nombre == dto.Nombre &&
               Modelo == dto.Modelo &&
               Tipo == dto.Tipo &&
               Descripcion == dto.Descripcion &&
               PrecioKwh == dto.PrecioKwh &&
               PrecioReserva == dto.PrecioReserva;
    }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Nombre, Modelo, Tipo, Descripcion, PrecioKwh, PrecioReserva);
        }

    }

}