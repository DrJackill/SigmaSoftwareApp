using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Consumes("multipart/form-data")]
    public class FormController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Post([FromForm] IFormFile image)
        {
            string path = Path.GetTempPath();
            Console.WriteLine("TEST");
            using (var ms = new MemoryStream())
            {
                image.CopyTo(ms);
                var fileBytes = ms.ToArray();
                await System.IO.File.WriteAllBytesAsync($"{path}\\{image.FileName}", fileBytes);
            }
            return Ok();
        }
    }
}
