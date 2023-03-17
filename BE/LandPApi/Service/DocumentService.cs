using Google.Apis.Drive.v3;
using LandPApi.Dto;
using LandPApi.IService;
using LandPApi.Models;
using LandPApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace LandPApi.Service
{
    public class DocumentService : IDocumentService
    {
        private readonly IRepository<Document> _repository;
        private readonly IRepository<Product> _repoPro;
        private readonly IDriveService _driveService;

        public DocumentService(IRepository<Document> repository, IRepository<Product> repoPro, IDriveService driveService)
        {
            _repository = repository;
            _repoPro = repoPro;
            _driveService = driveService;
        }
        public void AddFile(DocumentDto document)
        {
            var doc = new Document 
            { 
                Id = document.Id,
                ProductId = document.ProductId
            };
            _repository.Create(doc);
            _repository.Save();
        }

        public List<string> GetAll(Guid productId)
        {
            var doc = _repository.ReadByCondition(o => o.ProductId == productId).Select(o => o.Id).ToList();
            return doc;
        }

        public async Task<string> PostDrive(IFormFile file, Guid productId)
        {
            
            string[] s = file.FileName.Split('.');
            string ex = "." + s[s.Length - 1];
            Console.Write(file.FileName);
            var filePath = "image/download" + ex;
            if (file.Length > 0)
            {
                using (var stream = System.IO.File.Create(filePath))
                {
                    await file.CopyToAsync(stream);
                }
            }
            var id = _repoPro.ReadByCondition(o => o.Id == productId).FirstOrDefault()!.FolderId;

            var idFile = _driveService.AddFile(filePath, ex, id!);
            _repository.Create(new Document
            {
                Id = idFile,
                ProductId = productId
            });
            _repository.Save();
            return idFile;            
        }
    }
}
