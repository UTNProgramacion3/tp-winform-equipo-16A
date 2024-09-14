using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Domain.Entities
{
    public class Marca
    {
        [DisplayNameAttribute("ID")]
        public int id {  get; set; }

        [DisplayNameAttribute("Descripción")]
        public string descripcion { get; set; }

    }
}
