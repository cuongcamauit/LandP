using LandPApi.Dto;

namespace LandPApi.IService
{
    public interface IDocumentService
    {
        public void AddFile(DocumentDto document);
        List<string> GetAll(Guid productId);
        Task<string> PostDrive(IFormFile file, Guid productId);
    }
}
