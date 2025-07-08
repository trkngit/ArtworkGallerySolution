using Microsoft.AspNetCore.Mvc;
using ArtworkGallery.BLL.DTOs;
using ArtworkGallery.BLL.Interfaces;

namespace ArtworkGallery.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OwnerController : ControllerBase
    {
        private readonly IOwnerService _ownerService;

        public OwnerController(IOwnerService ownerService)
        {
            _ownerService = ownerService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var items = _ownerService.GetAllOwners();
            return Ok(items);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var item = _ownerService.GetOwnerById(id);
            if (item == null)
                return NotFound();
            return Ok(item);
        }

        [HttpPost]
        public IActionResult Create([FromBody] OwnerDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            _ownerService.AddOwner(dto);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] OwnerDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            dto.OwnerId = id;
            _ownerService.UpdateOwner(dto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existing = _ownerService.GetOwnerById(id);
            if (existing == null)
                return NotFound();
            _ownerService.DeleteOwner(id);
            return NoContent();
        }
    }
}
