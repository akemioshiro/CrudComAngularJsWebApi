using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudComAngularJsWebApi.Models
{
    public class Celular
    {
        [Key]
        public int Id { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public string Cor { get; set; }

        public string TipoChip { get; set; }

        public string MemoriaInterna { get; set; }

    }
}
