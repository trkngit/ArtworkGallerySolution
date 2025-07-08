using Microsoft.AspNetCore.Mvc;
using ArtworkGallery.BLL.DTOs;
using ArtworkGallery.BLL.Interfaces;

namespace ArtworkGallery.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExhibitionController : ControllerBase
    {
        private readonly IExhibitionService _exhibitionService;

        public ExhibitionController(IExhibitionService exhibitionService)
        {
            _exhibitionService = exhibitionService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var exhibitions = _exhibitionService.GetAllExhibitions();
            return Ok(exhibitions);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var exhibition = _exhibitionService.GetExhibitionById(id);
            if (exhibition == null)
                return NotFound();

            return Ok(exhibition);
        }

        [HttpPost]
        public IActionResult Create([FromBody] ExhibitionDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _exhibitionService.AddExhibition(dto);
            return Ok(); // or use CreatedAtAction for better REST response
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] ExhibitionDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            dto.ExhibitionId = id;
            _exhibitionService.UpdateExhibition(dto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existing = _exhibitionService.GetExhibitionById(id);
            if (existing == null)
                return NotFound();

            _exhibitionService.DeleteExhibition(id);
            return NoContent();
        }
    }
}