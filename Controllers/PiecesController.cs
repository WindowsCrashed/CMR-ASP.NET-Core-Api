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
            Piece piece = await _context.Pieces
                .Include(p => p.SheetMusic)
                .Include(p => p.AudioRecordings)
                .Include(p => p.VideoRecordings)
                .Include(p => p.Composer)
                .Include(p => p.Tonality)
                .Include(p => p.InstrumentPieces)
                .FirstAsync(p => p.Id == id);

            if (piece == null) return NotFound();

            return Ok(piece);
        }
    }
}
