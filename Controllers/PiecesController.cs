using CMRWebApi.Infrastructure;
using CMRWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CMRWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PiecesController : ControllerBase
    {
        private readonly CMRDbContext _context;

        public PiecesController(CMRDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetPieces()
        {
            return Ok(await _context.Pieces.ToListAsync());
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetPiece(Guid id)
        {
            Piece piece = await _context.Pieces.FindAsync(id);

            if (piece == null) return NotFound();

            return Ok(piece);
        }
    }
}
