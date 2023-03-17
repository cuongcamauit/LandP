using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using LandPApi.IService;
using static NuGet.Packaging.PackagingConstants;

namespace LandPApi.Service
{
    public class GGDriveService : IDriveService
    {
        private readonly DriveService _driveService;

        public GGDriveService()
        {
            string[] Scopes = { DriveService.Scope.Drive };
            string ApplicationName = "LanP";

            UserCredential credential;
            using (var stream = new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {

                string credPath = "token.json";

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,  // Quyền truy xuất dữ liệu của người dùng
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;

                Console.WriteLine("Credential file saved to: " + credPath);
            }

            // Tạo ra 1 dịch vụ Drive API - Create Drive API service với thông tin xác thực và ApplicationName
            _driveService = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
        }
        public string AddFile(string filePath, string ex, string folderId = "1Fp5cZ4J75621_nsSQizn2c4ovmt3Jsm4")
        {
            // ID thư mục file, các bạn thay bằng ID của các bạn khi chạy

            var fileMetadata = new Google.Apis.Drive.v3.Data.File()
            {
                // Tên file sẽ lưu trên Google Drive
                Name = Guid.NewGuid().ToString() + ex,

                // Thư mục chưa file
                Parents = new List<string> { folderId }
            };

            // Đường dẫn file trong thiết bị của bạn, dùng để upload lên Goolge Drive


            FilesResource.CreateMediaUpload request;
            using (var stream = new System.IO.FileStream(filePath, System.IO.FileMode.Open))
            {
                request = _driveService.Files.Create(fileMetadata, stream, "image/jpeg");

                // Cấu hình thông tin lấy về là ID
                request.Fields = "id";

                // thực hiện Upload
                request.Upload();
            }

            // Trả về thông tin file đã được upload lên Google Drive
            var file = request.ResponseBody;

            Console.WriteLine("File ID: " + file.Id);
            return "https://drive.google.com/uc?export=view&id=" + file.Id;
        }

        public string AddFolder(string folderName, string folderParent = "1Fp5cZ4J75621_nsSQizn2c4ovmt3Jsm4")
        {
            // File metadata
            var fileMetadata = new Google.Apis.Drive.v3.Data.File()
            {
                Name = folderName,
                MimeType = "application/vnd.google-apps.folder",
                // Thư mục chưa file
                Parents = new List<string> { folderParent }
            };

            // Create a new folder on drive.
            var request = _driveService.Files.Create(fileMetadata);
            request.Fields = "id";
            var file = request.Execute();
            // Prints the created folder id.
            Console.WriteLine("Folder ID: " + file.Id);
            return file.Id;
        }



        public bool RemoveFile(string id)
        {
            _driveService.Files.Delete(id).Execute();
            return true;
        }
    }
}
