using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntity.Salario
{
    public class SALARIO
    {
        [Key]
        public int Id_salario { get; set; }
        public long Valor { get; set; }
    }
}
