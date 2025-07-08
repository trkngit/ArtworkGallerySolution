using Microsoft.AspNetCore.Mvc;
using ArtworkGallery.BLL.DTOs;
using ArtworkGallery.BLL.Interfaces;

namespace ArtworkGallery.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StaffExhibitionController : ControllerBase
    {
        private readonly IStaffExhibitionService _staffExhibitionService;

        public StaffExhibitionController(IStaffExhibitionService staffExhibitionService)
        {
            _staffExhibitionService = staffExhibitionService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var items = _staffExhibitionService.GetAllStaffExhibitions();
            return Ok(items);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var item = _staffExhibitionService.GetStaffExhibitionById(id);
            if (item == null)
                return NotFound();
            return Ok(item);
        }

        [HttpPost]
        public IActionResult Create([FromBody] StaffExhibitionDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            _staffExhibitionService.AddStaffExhibition(dto);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] StaffExhibitionDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            dto.StaffExhibitionId = id;
            _staffExhibitionService.UpdateStaffExhibition(dto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existing = _staffExhibitionService.GetStaffExhibitionById(id);
            if (existing == null)
                return NotFound();
            _staffExhibitionService.DeleteStaffExhibition(id);
            return NoContent();
        }
    }
}
