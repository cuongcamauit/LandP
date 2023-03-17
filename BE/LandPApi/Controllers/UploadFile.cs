using LandPApi.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace LandPApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadFile : ControllerBase
    {
        private readonly IDriveService _driveService;

        public UploadFile(IDriveService driveService)
        {
            _driveService = driveService;
        }
        [HttpPost("File")]
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
            return Ok(_driveService.AddFile(filePath, ex));
        }
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> RemoveFile(string id)
        //{
        //    return Ok(_driveService.RemoveFile(id));
        //}
        //[HttpPost("Folder")]
        //public async Task<IActionResult> AddFolder(string name)
        //{
        //    return Ok(_driveService.AddFolder(name));
        //}
    }
}
