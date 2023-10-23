using DataAccess.Empleados;
using DataEntity.Empleados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogic.Empleados
{
    public class EmpleadosLogica
    {
        private readonly EmpleadosMetodos mt;
        public EmpleadosLogica(EmpleadosMetodos mt) 
        { 
            this.mt = mt;
        }
        public async Task<List<EMPLEADOS>> GetAll() 
        { 
            return await mt.GetAll(); 
        }
        public async Task<bool> Add(EMPLEADOS empleado) 
        { 
            return await mt.Add(empleado); 
        }
        public async Task<bool> Update(EMPLEADOS empleado) 
        { 
            return await mt.Update(empleado); 
        }
        public async Task<bool> Delete(long cedula) 
        { 
            return await mt.Delete(cedula); 
        }
    }
}
