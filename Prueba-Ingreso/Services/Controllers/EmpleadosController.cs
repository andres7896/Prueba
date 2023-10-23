using DataEntity.Empleados;
using DataLogic.Empleados;
using Microsoft.AspNetCore.Mvc;

namespace Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadosController : ControllerBase
    {
        private readonly EmpleadosLogica lg;
        public EmpleadosController(EmpleadosLogica lg)
        {
            this.lg = lg;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll() 
        {
            var empleados = await lg.GetAll();
            if (empleados == null) return BadRequest();
            return Ok(empleados);
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] EMPLEADOS empleado) 
        {
            var creado = await lg.Add(empleado);
            if (creado == false) return BadRequest();
            return Ok(creado);
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] EMPLEADOS empleado) 
        {
            var actualizado = await lg.Update(empleado);
            if (actualizado == false) return BadRequest();
            return Ok(actualizado);
        }
        [HttpDelete,Route("{cedula}")]
        public async Task<IActionResult> Delete(long cedula) 
        {
            var eliminado = await lg.Delete(cedula);
            if (eliminado == false) return BadRequest();
            return Ok(eliminado);
        }
    }
}
