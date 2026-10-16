namespace AppForSEII.API.DTOs
{
    public class ModeloParaComprarDTO
    {
        public ModeloParaComprarDTO()
        {
        }

        public ModeloParaComprarDTO(int id, string nombre, string categoria,
            string licencia, string formato, decimal precio)
        {
            Id = id;
            Nombre = nombre;
            Categoria = categoria;
            Licencia = licencia;
            Formato = formato;
            Precio = precio;
        }

        public int Id { get; set; }

        [StringLength(30, ErrorMessage = "Nombre cannot be longer than 30 characters.")]
        public string Nombre { get; set; }

        [StringLength(30, ErrorMessage = "Categoria cannot be longer than 30 characters.")]
        public string Categoria { get; set; }

        [StringLength(30, ErrorMessage = "Licencia cannot be longer than 30 characters.")]
        public string Licencia { get; set; }

        public string Formato { get; set; }

        [Precision(8, 2)]
        public decimal Precio { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is ModeloParaComprarDTO dto &&
                   Id == dto.Id &&
                   Nombre == dto.Nombre &&
                   Categoria == dto.Categoria &&
                   Licencia == dto.Licencia &&
                   Formato == dto.Formato &&
                   Precio == dto.Precio;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Nombre, Categoria, Licencia, Formato, Precio);
        }
    }
}