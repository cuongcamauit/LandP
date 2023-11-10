using LandPApi.Dto;
using LandPApi.IService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace LandPApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentsController : ControllerBase
    {
        private readonly IDocumentService _documentService;

        public DocumentsController(IDocumentService documentService)
        {
            _documentService = documentService;
        }
        [HttpPost("ProductLink")]
        [Authorize(Roles = "Admin")]
        public IActionResult Post(DocumentDto documentDto)
        {
            if (!ModelState.IsValid)
            {
                var message = string.Join(" | ", ModelState.Values
                            .SelectMany(v => v.Errors)
                            .Select(e => e.ErrorMessage));
                return Ok(new Response
                {
                    Success = false,
                    Message = "Some properties is wrong",
                    Data = message,
                    StatusCode = 422
                });
            }
            _documentService.AddFile(documentDto);
            return Ok(new Response
            {
                StatusCode = 201,
                Message = "Add link successful!",

            });
        }

        [HttpPost("ProductFile")]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> PostFile(IFormFile file, Guid productId)
        {
            if (!ModelState.IsValid)
            {
                var message = string.Join(" | ", ModelState.Values
                            .SelectMany(v => v.Errors)
                            .Select(e => e.ErrorMessage));
                return Ok(new Response
                {
                    Success = false,
                    Message = "Some properties is wrong",
                    Data = message,
                    StatusCode = 422
                });
            }
            return Ok(new Response
            {
                StatusCode = 201,
                Message = "Upload file successful!",
                Data = await _documentService.PostDrive(file, productId)
            });
        }

        [HttpGet]
        public IActionResult GetAll(Guid productId)
        {
            List<string> imgs = _documentService.GetAll(productId);
            return Ok(new Response
            {
                Data = imgs,
                Success = true,
                Message = "Get all document of product"
            });
        }
    }
}
