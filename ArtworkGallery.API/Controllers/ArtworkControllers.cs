using Microsoft.AspNetCore.Mvc;
using ArtworkGallery.BLL.Interfaces;
using ArtworkGallery.BLL.DTOs;

namespace ArtworkGallery.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArtworksController : ControllerBase
    {
        private readonly IArtworkService _artworkService;

        public ArtworksController(IArtworkService artworkService)
        {
            _artworkService = artworkService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var artworks = _artworkService.GetAllArtworks();
            return Ok(artworks);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var artwork = _artworkService.GetArtworkById(id);
            if (artwork == null)
                return NotFound();
            return Ok(artwork);
        }

        [HttpPost]
        public IActionResult Create([FromBody] ArtworkDto newArtwork)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _artworkService.AddArtwork(newArtwork);
            var createdArtwork = newArtwork; // Assuming newArtwork contains the created data
            return CreatedAtAction(nameof(GetById), new { id = createdArtwork.ArtworkId }, createdArtwork);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] ArtworkDto updatedArtwork)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existing = _artworkService.GetArtworkById(id);
            if (existing == null)
                return NotFound();

            updatedArtwork.ArtworkId = id;
            _artworkService.UpdateArtwork(updatedArtwork);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var artwork = _artworkService.GetArtworkById(id);
            if (artwork == null)
                return NotFound();

            _artworkService.DeleteArtwork(id);
            return NoContent();
        }
    }
    

}