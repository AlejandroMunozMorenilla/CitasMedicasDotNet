using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HOSPITAL.Data;
using Hospital.Model;
using Hospital.DTO;
using HOSPITAL.Services;

namespace HOSPITAL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitasController : Controller
    {
        private readonly CitaService _citaService;

        public CitasController(CitaService citaService)
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
        [ProducesResponseType(400)]
        public IActionResult PostCita(CitaDTO cita)
        {
            return Ok(_citaService.InsertCita(cita));
        }
    }
}
