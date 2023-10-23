using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntity.Cargos
{
    public class CARGOS
    {
        [Key]
        public string Cod_cargo { get; set; }
        public string Nombrecargo { get; set; }
    }
}
