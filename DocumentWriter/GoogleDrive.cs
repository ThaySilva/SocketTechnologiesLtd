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

namespace DocumentWriter
{
    public static class GoogleDrive
    {
        private static string FolderId = "0B_ob9qFmHlBccWVWbGhVX1NRbXc";
        private static string contentType = "application/pdf";
        private static string filePath = @"C:\Users\Sinea\Documents\";

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

                    MessageBox.Show("Credential file saved to: " + credPath);
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

        public static string UploadFile(DriveService service, string fileName, byte[] pdfBytes)
        {
            var fileMetadata = new Google.Apis.Drive.v3.Data.File();
            fileMetadata.Name = fileName;
            fileMetadata.Parents = new List<string> { FolderId };

            FilesResource.CreateMediaUpload request;
            System.IO.MemoryStream stream = new System.IO.MemoryStream(pdfBytes);

            request = service.Files.Create(fileMetadata, stream, contentType);
            request.Upload();


            var file = request.ResponseBody;

            return file.Id;
        }

        public static void DownloadFile(DriveService service, string fileId, string filePath)
        {
            var request = service.Files.Get(fileId);

            using (var memoryStream = new MemoryStream())
            {
                request.MediaDownloader.ProgressChanged += (IDownloadProgress progress) =>
                {
                    switch (progress.Status)
                    {
                        //case DownloadStatus.Downloading:
                        //    MessageBox.Show(progress.BytesDownloaded.ToString());
                        //    break;
                        case DownloadStatus.Completed:
                            MessageBox.Show("Download complete");
                            break;
                        case DownloadStatus.Failed:
                            MessageBox.Show("Download failed");
                            break;

                    }
                };

                request.Download(memoryStream);

                using (var filestream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    filestream.Write(memoryStream.GetBuffer(), 0, memoryStream.GetBuffer().Length);
                }

            }
        }

    }
}
