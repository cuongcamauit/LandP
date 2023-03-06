using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;

namespace LandPApi
{
    // Class to demonstrate use of Drive insert file API
    public class UploadBasic
    {
        /// <summary>
        /// Upload new file.
        /// </summary>
        /// <param name="filePath">Image path to upload.</param>
        /// <returns>Inserted file metadata if successful, null otherwise.</returns>
        public static string DriveUploadBasic(string filePath, string ex, string folderId = "1MqaO_2bK_c5H8vyMZ-KOF6dbUv0dQO1T")
        {
            var dictionary = new Dictionary<string, string>() {
                { "xls" ,"application/vnd.ms-excel"},
                { "xlsx" ,"application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"},
                { "xml" ,"text/xml"},
                { "ods","application/vnd.oasis.opendocument.spreadsheet"},
                { "csv","text/plain"},
                { "tmpl","text/plain"},
                { "pdf"," application/pdf"},
                { "php","application/x-httpd-php"},
                { "jpg","image/jpeg"},
                { "png","image/png"},
                { "gif","image/gif"},
                { "bmp","image/bmp"},
                { "txt","text/plain"},
                { "doc","application/msword"},
                { "js","text/js"},
                { "swf","application/x-shockwave-flash"},
                { "mp3","audio/mpeg"},
                { "zip","application/zip"},
                { "rar","application/rar"},
                { "tar","application/tar"},
                { "arj","application/arj"},
                { "cab","application/cab"},
                { "html","text/html"},
                { "htm","text/html"},
                { "default","application/octet-stream"},
                { "folder","application/vnd.google-apps.folder"},

            };
            // Thiết lập phạm vi truy xuất dữ liệu Scope = Drive để upload file
            string[] Scopes = { DriveService.Scope.Drive };
            string ApplicationName = "LanP";

            UserCredential credential;
            using (var stream = new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {

                // Thông tin về quyền truy xuất dữ liệu của người dùng được lưu ở thư mục token.json
                string credPath = "token.json";

                // Yêu cầu người dùng xác thực lần đầu và thông tin sẽ được lưu vào thư mục token.json
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,  // Quyền truy xuất dữ liệu của người dùng
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;

                Console.WriteLine("Credential file saved to: " + credPath);
            }

            // Tạo ra 1 dịch vụ Drive API - Create Drive API service với thông tin xác thực và ApplicationName
            var driveService = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

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
                request = driveService.Files.Create(fileMetadata, stream, "image/jpeg");

                // Cấu hình thông tin lấy về là ID
                request.Fields = "id";

                // thực hiện Upload
                request.Upload();
            }

            // Trả về thông tin file đã được upload lên Google Drive
            var file = request.ResponseBody;

            Console.WriteLine("File ID: " + file.Id);
            return "https://drive.google.com/file/d/" + file.Id + "/view";
        }
    }
}