using Microsoft.AspNetCore.Mvc;
using ArtworkGallery.BLL.DTOs;
using ArtworkGallery.BLL.Interfaces;

namespace ArtworkGallery.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArtworkExhibitionController : ControllerBase
    {
        private readonly IArtworkExhibitionService _artworkExhibitionService;

        public ArtworkExhibitionController(IArtworkExhibitionService artworkExhibitionService)
        {
            _artworkExhibitionService = artworkExhibitionService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var items = _artworkExhibitionService.GetAllArtworkExhibitions();
            return Ok(items);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var item = _artworkExhibitionService.GetArtworkExhibitionById(id);
            if (item == null)
                return NotFound();
            return Ok(item);
        }

        [HttpPost]
        public IActionResult Create([FromBody] ArtworkExhibitionDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            _artworkExhibitionService.AddArtworkExhibition(dto);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] ArtworkExhibitionDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            dto.ArtworkExhibitionId = id;
            _artworkExhibitionService.UpdateArtworkExhibition(dto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existing = _artworkExhibitionService.GetArtworkExhibitionById(id);
            if (existing == null)
                return NotFound();
            _artworkExhibitionService.DeleteArtworkExhibition(id);
            return NoContent();
        }
    }
}
