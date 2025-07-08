using Microsoft.AspNetCore.Mvc;
using ArtworkGallery.BLL.DTOs;
using ArtworkGallery.BLL.Interfaces;

namespace ArtworkGallery.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionService _transactionService;

        public TransactionController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var items = _transactionService.GetAllTransactions();
            return Ok(items);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var item = _transactionService.GetTransactionById(id);
            if (item == null)
                return NotFound();
            return Ok(item);
        }

        [HttpPost]
        public IActionResult Create([FromBody] TransactionDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            _transactionService.AddTransaction(dto);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] TransactionDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            dto.TransactionId = id;
            _transactionService.UpdateTransaction(dto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existing = _transactionService.GetTransactionById(id);
            if (existing == null)
                return NotFound();
            _transactionService.DeleteTransaction(id);
            return NoContent();
        }
    }
}
