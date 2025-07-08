using Microsoft.AspNetCore.Mvc;
using ArtworkGallery.BLL.DTOs;
using ArtworkGallery.BLL.Interfaces;

namespace ArtworkGallery.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OwnerTransactionController : ControllerBase
    {
        private readonly IOwnerTransactionService _ownerTransactionService;

        public OwnerTransactionController(IOwnerTransactionService ownerTransactionService)
        {
            _ownerTransactionService = ownerTransactionService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var items = _ownerTransactionService.GetAllOwnerTransactions();
            return Ok(items);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var item = _ownerTransactionService.GetOwnerTransactionById(id);
            if (item == null)
                return NotFound();
            return Ok(item);
        }

        [HttpPost]
        public IActionResult Create([FromBody] OwnerTransactionDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            _ownerTransactionService.AddOwnerTransaction(dto);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] OwnerTransactionDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            dto.OwnerTransactionId = id;
            _ownerTransactionService.UpdateOwnerTransaction(dto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existing = _ownerTransactionService.GetOwnerTransactionById(id);
            if (existing == null)
                return NotFound();
            _ownerTransactionService.DeleteOwnerTransaction(id);
            return NoContent();
        }
    }
}
