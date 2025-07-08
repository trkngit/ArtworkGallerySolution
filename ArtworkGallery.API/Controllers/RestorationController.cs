using Microsoft.AspNetCore.Mvc;
using ArtworkGallery.BLL.DTOs;
using ArtworkGallery.BLL.Interfaces;

namespace ArtworkGallery.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RestorationController : ControllerBase
    {
        private readonly IRestorationService _restorationService;

        public RestorationController(IRestorationService restorationService)
        {
            _restorationService = restorationService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var items = _restorationService.GetAllRestorations();
            return Ok(items);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var item = _restorationService.GetRestorationById(id);
            if (item == null)
                return NotFound();
            return Ok(item);
        }

        [HttpPost]
        public IActionResult Create([FromBody] RestorationDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            _restorationService.AddRestoration(dto);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] RestorationDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            dto.RestorationId = id;
            _restorationService.UpdateRestoration(dto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existing = _restorationService.GetRestorationById(id);
            if (existing == null)
                return NotFound();
            _restorationService.DeleteRestoration(id);
            return NoContent();
        }
    }
}
