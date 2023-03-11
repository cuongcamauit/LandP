using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace LandPApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadFile : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> UpFile(IFormFile file)
        {
            string[] s = file.FileName.Split('.');
            string ex = "."+s[s.Length - 1];


            Console.Write(file.FileName);
            var filePath = "image/download"+ex;
            if (file.Length > 0)
            {
                using (var stream = System.IO.File.Create(filePath))
                {
                    await file.CopyToAsync(stream);
                }
            }
            return Ok(UploadBasic.DriveUploadBasic(filePath, ex));
        }
    }
}
