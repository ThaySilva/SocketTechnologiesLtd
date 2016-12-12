using Google.Apis.Auth.OAuth2;
using Google.Apis.Download;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLayer
{
    public static class GoogleDrive
    {     
        private static string contentType = "application/pdf";

        public static DriveService getService()
        {
            string[] scopes = new string[] { DriveService.Scope.Drive };
            string AppName = "sockettechnologiesltd";

            try
            {
                UserCredential credential;

                using (var stream =
                    new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
                {
                    string credPath = System.Environment.GetFolderPath(
                        System.Environment.SpecialFolder.Personal);
                    credPath = Path.Combine(credPath, ".credentials/drive-dotnet-quickstart.json");

                    credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                        GoogleClientSecrets.Load(stream).Secrets, scopes, "user",
                        CancellationToken.None,
                        new FileDataStore(credPath, true)).Result;
                }

                // Create Drive API service.
                DriveService service = new DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = AppName,
                });

                return service;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                return null;


            }
        }

        public static string UploadFile(DriveService service, string fileName, string filePath, string FolderId)
        {
            var fileMetadata = new Google.Apis.Drive.v3.Data.File();
            fileMetadata.Name = fileName;
            fileMetadata.Parents = new List<string> { FolderId };

            FilesResource.CreateMediaUpload request;

           // System.IO.MemoryStream stream = new System.IO.MemoryStream(pdfBytes);
            using (var stream = new FileStream(filePath, FileMode.Open))
            {
                request = service.Files.Create(fileMetadata, stream, contentType);
                request.Upload();
            }

            var file = request.ResponseBody;

            return file.Id;
        }

        public static void DownloadFile(DriveService service, string fileId, string filePath)
        {
            var request = service.Files.Get(fileId);

            using (var memoryStream = new MemoryStream())
            {
                request.Download(memoryStream);

                using (var filestream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    filestream.Write(memoryStream.GetBuffer(), 0, memoryStream.GetBuffer().Length);
                }

            }
        }

    }
}
