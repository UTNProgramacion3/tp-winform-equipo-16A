
namespace Business.Dtos
{
    public class ArticuloDTO
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }

        public int MarcaId { get; set; }
        public string MarcaDescripcion { get; set; }

        public int CategoriaId { get; set; }
        public string CategoriaDescripcion { get; set; }
    }
}
