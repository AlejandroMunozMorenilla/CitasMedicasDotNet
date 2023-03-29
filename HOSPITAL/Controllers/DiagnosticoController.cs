using Hospital.DTO;
using HOSPITAL.Exceptions;
using HOSPITAL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace HOSPITAL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiagnosticoController : Controller
    {
        private readonly IDiagnosticoService _diagnosticoService;

        public DiagnosticoController(IDiagnosticoService diagnosticoService)
        {
            _diagnosticoService = diagnosticoService;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(ICollection<DiagnosticoDTO>))]
        public ICollection<DiagnosticoDTO> GetCitas()
        {
            return _diagnosticoService.GetDiagnosticos();
        }

        [HttpGet("{citaId}")]
        [ProducesResponseType(200, Type = typeof(DiagnosticoDTO))]
        public IActionResult GetCitasById(int citaId)
        {
            try
            {
                return Ok(_diagnosticoService.GetDiagnosticoById(citaId));
            }
            catch (NotFoundException nfe)
            { 
                return NotFound();
            }
        }

        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(500)]
        public IActionResult PostCita(DiagnosticoDTO diagnostico)
        {
            try
            {
                _diagnosticoService.InsertDiagnostico(diagnostico);
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
        public IActionResult PutCita(DiagnosticoDTO diagnostico)
        {
            try
            {
                _diagnosticoService.UpdateDiagnostico(diagnostico);
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
                _diagnosticoService.DeleteDiagnostico(id);
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
