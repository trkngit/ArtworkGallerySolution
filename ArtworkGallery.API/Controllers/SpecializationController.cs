using Microsoft.AspNetCore.Mvc;
using ArtworkGallery.BLL.DTOs;
using ArtworkGallery.BLL.Interfaces;

namespace ArtworkGallery.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SpecializationController : ControllerBase
    {
        private readonly ISpecializationService _specializationService;

        public SpecializationController(ISpecializationService specializationService)
        {
            _specializationService = specializationService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var items = _specializationService.GetAllSpecializations();
            return Ok(items);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var item = _specializationService.GetSpecializationById(id);
            if (item == null)
                return NotFound();
            return Ok(item);
        }

        [HttpPost]
        public IActionResult Create([FromBody] SpecializationDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            _specializationService.AddSpecialization(dto);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] SpecializationDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            dto.SpecializationId = id;
            _specializationService.UpdateSpecialization(dto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existing = _specializationService.GetSpecializationById(id);
            if (existing == null)
                return NotFound();
            _specializationService.DeleteSpecialization(id);
            return NoContent();
        }
    }
}
