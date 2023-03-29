using Hospital.DTO;
using HOSPITAL.Exceptions;
using HOSPITAL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HOSPITAL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicoController : Controller
    {
        private readonly IMedicoService _medicoService;

        public MedicoController(IMedicoService medicoService)
        {
            _medicoService = medicoService;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(ICollection<MedicoDTO>))]
        public ICollection<MedicoDTO> GetCitas()
        {
            return _medicoService.GetMedicos();
        }

        [HttpGet("{citaId}")]
        [ProducesResponseType(200, Type = typeof(MedicoDTO))]
        public IActionResult GetCitas(int medicoId)
        {
            try
            { 
                return Ok(_medicoService.GetMedicoById(medicoId));
            }
            catch (NotFoundException nfe)
            {
                return NotFound();
            }
        }

        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(500)]
        public IActionResult PostCita(MedicoDTO medico)
        {
            try
            {
                _medicoService.InsertMedico(medico);
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
        public IActionResult PutCita(MedicoDTO medico)
        {
            try
            {
                _medicoService.UpdateMedico(medico);
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
        public IActionResult DeleteCita(int medicoId)
        {
            try
            {
                _medicoService.DeleteMedico(medicoId);
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
