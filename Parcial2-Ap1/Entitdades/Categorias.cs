using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_Ap1.Entitdades
{
    public class Categorias
    {
        [Key]
        public int CategoriaId { get; set; }
        public string Decripcion { get; set; }

        public Categorias(int categoriaId, string decripcion)
        {
            CategoriaId = categoriaId;
            Decripcion = decripcion;
        }

        public Categorias()
        {
            CategoriaId = 0;
            Decripcion = string.Empty;
        }
    }
}
