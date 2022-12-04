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

        [HttpGet]
        public async Task<IActionResult> GetComposers()
        {
            return Ok(await _context.Composers.ToListAsync());
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetComposer(Guid id)
        {
            Composer composer = await _context.Composers.FindAsync(id);

            if (composer == null) return NotFound();

            return Ok(composer);
        }
    }
}
