using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Articulo
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int IdMarca { get; set; }
        public int IdCategoria { get; set; }
        public decimal Precio { get; set; }

        public Articulo()
        { }

        public Articulo(int Id, string Codigo, string Nombre, string Descripcion, int IdMarca, int IdCategoria, decimal Precio)
        {
            this.Id = Id;
            this.Codigo = Codigo;
            this.Nombre = Nombre;
            this.Descripcion = Descripcion;
            this.IdMarca = IdMarca;
            this.IdCategoria = IdCategoria;
            this.Precio = Precio;
        }
    }
}
