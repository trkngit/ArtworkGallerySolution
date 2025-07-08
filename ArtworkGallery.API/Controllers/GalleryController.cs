using Microsoft.AspNetCore.Mvc;
using ArtworkGallery.BLL.DTOs;
using ArtworkGallery.BLL.Interfaces;

namespace ArtworkGallery.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GalleryController : ControllerBase
    {
        private readonly IGalleryService _galleryService;

        public GalleryController(IGalleryService galleryService)
        {
            _galleryService = galleryService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var galleries = _galleryService.GetAllGalleries();
            return Ok(galleries);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var gallery = _galleryService.GetGalleryById(id);
            if (gallery == null)
                return NotFound();

            return Ok(gallery);
        }

        [HttpPost]
        public IActionResult Create([FromBody] GalleryDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _galleryService.AddGallery(dto);
            return Ok(); // or return CreatedAtAction(...) if you return the new ID
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] GalleryDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            dto.GalleryId = id;
            _galleryService.UpdateGallery(dto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existing = _galleryService.GetGalleryById(id);
            if (existing == null)
                return NotFound();

            _galleryService.DeleteGallery(id);
            return NoContent();
        }
    }
}