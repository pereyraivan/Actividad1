using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1.MODELO
{
    class Comments
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Comments Comment { get; set; }
        public ICollection<Usuario> Usuarios{ get; set; }
    }
}
