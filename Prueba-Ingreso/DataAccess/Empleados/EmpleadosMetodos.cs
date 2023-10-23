using DataAccess.Context;
using DataEntity.Empleados;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Empleados
{
    public class EmpleadosMetodos
    {
        private readonly DbConnection ctx;
        public EmpleadosMetodos(DbConnection context) 
        { 
            ctx = context;
        }
        public async Task<List<EMPLEADOS>> GetAll()
        {
            try
            {
                return await ctx.EMPLEADOS
                                .Include(e => e.Cargo)
                                .Include(e => e.Salario)
                                .ToListAsync();
            }
            catch
            {
                return null;
            }
        }
        public async Task<bool> Add(EMPLEADOS empleado)
        {
            try
            {
                await ctx.EMPLEADOS.AddAsync(empleado);
                await ctx.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public async Task<bool> Update(EMPLEADOS empleado)
        {
            try
            {
                EMPLEADOS empleadoFound = await ctx.EMPLEADOS.FirstOrDefaultAsync(e => e.Cedula == empleado.Cedula);
                if (empleadoFound == null) return false;
                empleadoFound.Nombre1 = empleado.Nombre1;
                empleadoFound.Nombre2 = empleado.Nombre2;
                empleadoFound.Apellido1 = empleado.Apellido1;
                empleadoFound.Apellido2 = empleado.Apellido2;
                empleadoFound.Cod_cargo = empleado.Cod_cargo;
                empleadoFound.Id_salario = empleado.Id_salario;
                await ctx.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public async Task<bool> Delete(long cedula)
        {
            try
            {
                EMPLEADOS empleadoFound = await ctx.EMPLEADOS.FirstOrDefaultAsync(e => e.Cedula == cedula);
                if (empleadoFound == null) return false;
                ctx.EMPLEADOS.Remove(empleadoFound);
                await ctx.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
