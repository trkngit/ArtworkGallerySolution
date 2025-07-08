using Microsoft.AspNetCore.Mvc;
using ArtworkGallery.BLL.Interfaces;
using ArtworkGallery.BLL.DTOs;

namespace ArtworkGallery.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CritiqueController : ControllerBase
    {
        private readonly ICritiqueService _critiqueService;

        public CritiqueController(ICritiqueService critiqueService)
        {
            _critiqueService = critiqueService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _critiqueService.GetAllCritiques();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = _critiqueService.GetCritiqueById(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create([FromBody] CritiqueDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _critiqueService.AddCritique(dto);
            var created = _critiqueService.GetCritiqueById(dto.CritiqueId); // Assuming you can retrieve it by ID
            return CreatedAtAction(nameof(GetById), new { id = created.CritiqueId }, created);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] CritiqueDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            dto.CritiqueId = id;
            _critiqueService.UpdateCritique(dto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var item = _critiqueService.GetCritiqueById(id);
            if (item == null)
                return NotFound();

            _critiqueService.DeleteCritique(id);
            return NoContent();
        }
    }
}
