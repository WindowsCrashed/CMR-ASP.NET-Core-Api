using CMRWebApi.Dto;
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
            var pieces = await _context.Pieces
                .Include(p => p.Tonality)
                .Include(p => p.Composer)
                .OrderBy(p => p.Composer.LastName)
                .ThenBy(p => p.Name)
                .ToListAsync();

            var pieceDtos = pieces.Select(p => 
                new PieceDto()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Catalog = p.Catalog,
                    Tonality = p.Tonality.Name,
                    ComposerId = p.ComposerId,
                    Composer = p.Composer.LastName
                });

            return Ok(pieceDtos);
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
                    .ThenInclude(ip => ip.Instrument)
                .FirstAsync(p => p.Id == id);

            if (piece == null) return NotFound();

            PieceDetailedDto pieceDto = new()
            {
                Id = piece.Id,
                Name = piece.Name,
                Catalog = piece.Catalog,
                Year = piece.Year,
                Movements = piece.Movements,
                Tonality = piece.Tonality.Name,
                Composer = new ComposerDto() {
                    Id = piece.ComposerId,
                    Name = piece.Composer.Name,
                    LastName = piece.Composer.LastName,
                    Period = piece.Composer.Period
                },
                AudioRecordings = piece.AudioRecordings.Select(ar =>
                    new AudioRecordingDto()
                    {
                        AudioPath = ar.AudioPath,
                        ImagePath = ar.ImagePath,
                        Performers = ar.Performers,
                        RecordLabel = ar.RecordLabel
                    }),
                VideoRecordings = piece.VideoRecordings.Select(vr => 
                    new VideoRecordingDto()
                    {
                        Url = vr.Url,
                        Performers = vr.Performers,
                        Channel = vr.Channel
                    }),
                SheetMusic = piece.SheetMusic.Select(sm => 
                    new SheetMusicDto()
                    {
                        Url = sm.Url
                    }),
                Instruments = piece.InstrumentPieces.Select(ip => 
                    new InstrumentDto()
                    {
                        Name = ip.Instrument.Name
                    })
            };

            return Ok(pieceDto);
        }
    }
}
