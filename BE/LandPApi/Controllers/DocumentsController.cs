using LandPApi.Dto;
using LandPApi.IService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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
            _documentService.AddFile(documentDto);
            return Ok();
        }

        [HttpPost("ProductFile")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> PostFile(IFormFile file, Guid productId)
        {
            
            return Ok(await _documentService.PostDrive(file, productId));
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
