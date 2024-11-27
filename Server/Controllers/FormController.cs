using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Consumes("multipart/form-data")]
    public class FormController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Post([FromForm] IFormFile file)
        {
            string path = Path.GetTempPath();
            Console.WriteLine("TEST");
            using (var ms = new MemoryStream())
            {
                file.CopyTo(ms);
                var fileBytes = ms.ToArray();
                await System.IO.File.WriteAllBytesAsync($"{path}\\{file.FileName}", fileBytes);
            }
            return Ok();
        }
    }
}
