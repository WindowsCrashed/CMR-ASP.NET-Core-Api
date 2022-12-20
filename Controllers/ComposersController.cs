using CMRWebApi.Dto;
using CMRWebApi.Infrastructure;
using CMRWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CMRWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ComposersController : ControllerBase
    {
        private readonly CMRDbContext _context;

        public ComposersController(CMRDbContext context)
        {
            _context = context;
        }

        [HttpGet("search")]
        public async Task<IActionResult> GetComposers()
        {
            var composers = await _context.Composers
                .OrderBy(c => c.LastName)
                .ThenBy(c => c.Name)
                .ToListAsync();

            var composerDtos = composers.Select(c => 
                new ComposerDto
                {
                    Id = c.Id,
                    Name = c.Name,
                    LastName = c.LastName,
                    Nationality = c.Nationality,
                    Period = c.Period
                }
            );

            return Ok(composerDtos);
        }

        [HttpGet("search/{filter}")]
        public async Task<IActionResult> GetComposersByFilter(string filter)
        {
            var composers = await _context.Composers
                .OrderBy(c => c.LastName)
                .ThenBy(c => c.Name)
                .Where(c =>
                    EF.Functions.Like(c.Name, $"%{filter}%") ||
                    EF.Functions.Like(c.LastName, $"%{filter}%") ||
                    EF.Functions.Like(c.Nationality, $"%{filter}%") ||
                    EF.Functions.Like(c.Period, $"%{filter}%"))
                .ToListAsync();

            var composerDtos = composers.Select(c =>
                new ComposerDto
                {
                    Id = c.Id,
                    Name = c.Name,
                    LastName = c.LastName,
                    Nationality = c.Nationality,
                    Period = c.Period
                }
            );

            return Ok(composerDtos);
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetComposer(Guid id)
        {
            Composer composer = await _context.Composers
                .Include(c => c.Pieces)
                    .ThenInclude(p => p.Tonality)
                .FirstAsync(c => c.Id == id);

            if (composer == null) return NotFound();

            ComposerDetailedDto composerDto = new()
            {
                Id = composer.Id,
                Name = composer.Name,
                LastName = composer.LastName,
                Nationality = composer.Nationality,
                Period = composer.Period,
                Birth = composer.Birth,
                Death = composer.Death,
                History = composer.History,
                ImgPath = composer.ImgPath,
                Pieces = composer.Pieces.Select(p => new PieceShortDto()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Tonality = p.Tonality.Name,
                    Catalog = p.Catalog
                }).OrderBy(p => p.Name)
            };

            return Ok(composerDto);
        }
    }
}
