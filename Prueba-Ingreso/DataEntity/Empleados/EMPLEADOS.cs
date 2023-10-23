using DataEntity.Cargos;
using DataEntity.Salario;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataEntity.Empleados
{
    public class EMPLEADOS
    {
        //Key referencia a la llave primaria
        [Key]
        //Bigint = long
        public long Cedula { get; set; }
        public string Nombre1 { get; set; }
        public string? Nombre2 { get; set; }
        public string Apellido1 { get; set; }
        public string? Apellido2 { get; set; }
        [ForeignKey("Cargo")]
        public string Cod_cargo { get; set; }
        public virtual CARGOS? Cargo { get; set; }
        [ForeignKey("Salario")]
        public int Id_salario { get; set; }
        public virtual SALARIO? Salario { get; set; }
    }
}
