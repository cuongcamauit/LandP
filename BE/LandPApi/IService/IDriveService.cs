using Microsoft.CodeAnalysis.Diagnostics;

namespace LandPApi.IService
{
    public interface IDriveService
    {
        public string AddFile(string filePath, string ex, string folderId = "1Fp5cZ4J75621_nsSQizn2c4ovmt3Jsm4");
        public bool RemoveFile(string id);
        public string AddFolder(string folderName, string folderParentID = "1Fp5cZ4J75621_nsSQizn2c4ovmt3Jsm4");
    }
}
