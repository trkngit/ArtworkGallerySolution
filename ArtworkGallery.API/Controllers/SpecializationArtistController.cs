using Microsoft.AspNetCore.Mvc;
using ArtworkGallery.BLL.DTOs;
using ArtworkGallery.BLL.Interfaces;

namespace ArtworkGallery.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SpecializationArtistController : ControllerBase
    {
        private readonly ISpecializationArtistService _specializationArtistService;

        public SpecializationArtistController(ISpecializationArtistService specializationArtistService)
        {
            _specializationArtistService = specializationArtistService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var items = _specializationArtistService.GetAllSpecializationArtists();
            return Ok(items);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var item = _specializationArtistService.GetSpecializationArtistById(id);
            if (item == null)
                return NotFound();
            return Ok(item);
        }

        [HttpPost]
        public IActionResult Create([FromBody] SpecializationArtistDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            _specializationArtistService.AddSpecializationArtist(dto);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] SpecializationArtistDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            dto.SpecializationArtistId = id;
            _specializationArtistService.UpdateSpecializationArtist(dto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existing = _specializationArtistService.GetSpecializationArtistById(id);
            if (existing == null)
                return NotFound();
            _specializationArtistService.DeleteSpecializationArtist(id);
            return NoContent();
        }
    }
}
