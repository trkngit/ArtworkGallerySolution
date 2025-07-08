using Microsoft.AspNetCore.Mvc;
using ArtworkGallery.BLL.Interfaces;
using ArtworkGallery.BLL.DTOs;

namespace ArtworkGallery.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArtistController : ControllerBase
    {
        private readonly IArtistService _artistService;

        public ArtistController(IArtistService artistService)
        {
            _artistService = artistService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var artists = _artistService.GetAllArtists();
            return Ok(artists);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var artist = _artistService.GetArtistById(id);
            if (artist == null)
                return NotFound();

            return Ok(artist);
        }

        [HttpPost]
        public IActionResult Create([FromBody] ArtistDto newArtist)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _artistService.AddArtist(newArtist);
            var createdArtist = newArtist; // Assuming newArtist is updated with the created artist details
            return CreatedAtAction(nameof(GetById), new { id = createdArtist.ArtistId }, createdArtist);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] ArtistDto updatedArtist)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existing = _artistService.GetArtistById(id);
            if (existing == null)
                return NotFound();

            updatedArtist.ArtistId = id;
            _artistService.UpdateArtist(updatedArtist);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var artist = _artistService.GetArtistById(id);
            if (artist == null)
                return NotFound();

            _artistService.DeleteArtist(id);
            return NoContent();
        }
    }
}