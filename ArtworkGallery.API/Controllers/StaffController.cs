using Microsoft.AspNetCore.Mvc;
using ArtworkGallery.BLL.DTOs;
using ArtworkGallery.BLL.Interfaces;

namespace ArtworkGallery.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staffService;

        public StaffController(IStaffService staffService)
        {
            _staffService = staffService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var items = _staffService.GetAllStaff();
            return Ok(items);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var item = _staffService.GetStaffById(id);
            if (item == null)
                return NotFound();
            return Ok(item);
        }

        [HttpPost]
        public IActionResult Create([FromBody] StaffDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            _staffService.AddStaff(dto);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] StaffDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            dto.StaffId = id;
            _staffService.UpdateStaff(dto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existing = _staffService.GetStaffById(id);
            if (existing == null)
                return NotFound();
            _staffService.DeleteStaff(id);
            return NoContent();
        }
    }
}
