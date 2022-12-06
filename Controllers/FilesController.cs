using Microsoft.AspNetCore.Mvc;

namespace CMRWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FilesController : ControllerBase
    {
        [HttpGet("imgs/{name}")]
        public IActionResult GetImg(string name)
        {
            try
            {
                byte[] b = System.IO.File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/imgs/{name}"));
                string extension = Path.GetExtension(name)[1..];
                return File(b, $"image/{extension}");
            }
            catch
            {
                return NotFound();
            }
        }

        [HttpGet("audio/{name}")]
        public IActionResult GetAudio(string name)
        {
            try
            {
                byte[] b = System.IO.File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/audio/{name}"));
                string extension = Path.GetExtension(name)[1..];
                return File(b, $"audio/{extension}", enableRangeProcessing:true);
            }
            catch
            {
                return NotFound();
            }
        }
    }
}
