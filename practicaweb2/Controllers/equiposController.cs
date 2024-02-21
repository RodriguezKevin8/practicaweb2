using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using practicaweb2.Models;

namespace practicaweb2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class equiposController : ControllerBase
    {
        private readonly EquiposContext _equiposContext;

        public equiposController(EquiposContext equiposContext)
        {
            _equiposContext = equiposContext;
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult Get()
        {
            List<Equipo> equipos = (from e in _equiposContext.Equipos select e).ToList();

            if (equipos.Count() > 0)
            {
                return Ok(equipos);
            }
            else
            {
                return NotFound();

            }

        }
    }
}
