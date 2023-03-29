using Microsoft.AspNetCore.Mvc;
using Hospital.DTO;
using HOSPITAL.Interfaces;
using HOSPITAL.Exceptions;

namespace HOSPITAL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitasController : Controller
    {
        private readonly ICitaService _citaService;

        public CitasController(ICitaService citaService)
        {
            _citaService = citaService;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(ICollection<CitaDTO>))]
        public IActionResult GetCitas() 
        { 
            return Ok(_citaService.GetCitas());
        }

        [HttpGet("{citaId}")]
        [ProducesResponseType(200, Type = typeof(CitaDTO))]
        public IActionResult GetCitas(int citaId)
        {
            return Ok(_citaService.GetCitaById(citaId));
        }

        [HttpPost]
        [ProducesResponseType(201, Type = typeof(CitaDTO))]
        [ProducesResponseType(500)]
        public IActionResult PostCita(CitaDTO cita)
        {
            try
            {
                _citaService.InsertCita(cita);
                return Ok();
            }
            catch (InsertException ie)
            {
                return StatusCode(500, ie.Message);
            }
        }

        [HttpPut]
        [ProducesResponseType(201)]
        [ProducesResponseType(500)]
        public IActionResult PutCita(CitaDTO cita)
        {
            try
            {
                _citaService.UpdateCita(cita);
                return Ok();
            }
            catch (UpdateException ue)
            {
                return StatusCode(500, ue.Message);
            }
        }

        [HttpDelete]
        [ProducesResponseType(200, Type = typeof(CitaDTO))]
        [ProducesResponseType(404)]
        public IActionResult DeleteCita(int id)
        {
            try
            {
                _citaService.DeleteCita(id);
                return Ok();
            }
            catch (NotFoundException nfe)
            {
                return NotFound();
            }
            catch (DeleteException de)
            {
                return StatusCode(500, de.Message);
            }
        }
    }
}
