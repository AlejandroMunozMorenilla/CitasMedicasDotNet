using Hospital.DTO;
using HOSPITAL.Exceptions;
using HOSPITAL.Interfaces;
using HOSPITAL.Services;
using Microsoft.AspNetCore.Mvc;

namespace HOSPITAL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacienteController : Controller
    {
        private readonly IPacienteService _pacienteService;

        public PacienteController(IPacienteService pacienteService)
        {
            _pacienteService = pacienteService;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(ICollection<PacienteDTO>))]
        public ICollection<PacienteDTO> GetCitas()
        {
            return _pacienteService.GetPacientes();
        }

        [HttpGet("{citaId}")]
        [ProducesResponseType(200, Type = typeof(PacienteDTO))]
        public IActionResult GetCitasById(int citaId)
        {
            try
            {
                return Ok(_pacienteService.GetPaceinteById(citaId));
            }
            catch (NotFoundException nfe)
            {
                return NotFound();
            }

        }

        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public IActionResult PostCita(PacienteDTO diagnostico)
        {
            try
            {
                _pacienteService.InsertPaciente(diagnostico);
                return Ok();
            }
            catch (InsertException ie)
            {
                return StatusCode(500, ie.Message);
            }
        }

        [HttpPut]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public IActionResult PutCita(PacienteDTO diagnostico)
        {
            try
            {
                _pacienteService.UpdatePaciente(diagnostico);
                return Ok();
            }
            catch (NotFoundException nfe)
            {
                return NotFound();
            }
            catch (UpdateException ue)
            {
                return StatusCode(500, ue.Message);
            }

        }

        [HttpDelete]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public IActionResult DeleteCita(int id)
        {
            try
            {
                _pacienteService.DeletePaciente(id);
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
