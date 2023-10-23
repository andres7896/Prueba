using DataEntity.Cargos;
using DataEntity.Empleados;
using DataEntity.Salario;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Context
{
    public class DbConnection: DbContext
    {
        public DbSet<EMPLEADOS> EMPLEADOS { get; set; }
        public DbSet<CARGOS> CARGOS { get; set; }
        public DbSet<SALARIO> SALARIO { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Data Source = DESKTOP-77701M3; Initial Catalog = Prueba; Persist security info = true; Integrated Security = true; Trust Server Certificate = true; multipleactiveresultsets = true; application name = EntityFramework providerName = System.Data.SqlClient");
        }
    }
}
