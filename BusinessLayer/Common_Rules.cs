using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using Google.Apis.Drive.v3;
using Google.Apis.Services;

namespace BusinessLayer
{
    public class Common_Rules
    {
        private static IDataLayer _data = DataLayer.GetInstance();
        private static IModel model = Model.GetInstance(_data);
        private static string pdfName;
        private static string pdfPath;
        private static string uploadName;
        private static string uploadPath;
        private static string _FolderId;
        private static string tableName;
        private static string reportDate;
        private static string _fileId;
        private static string _filePath;


        #region Document Functions
        #region Set PDF functions
        public static void setPdf(string name, string path)
        {
            pdfName = name;
            pdfPath = path;
        }

        public string getPdfName() { return pdfName; }

        public string getPdfPath() { return pdfPath; }
        #endregion

        #region Upload and Download Functions
        public static void setUpload(string name, string path, string FolderId)
        {
            uploadName = name;
            uploadPath = path;
            _FolderId = FolderId;

        }

        public static void setDatabaseUpload(string table, string date)
        {
            tableName = table;
            reportDate = date;
        }

        public static void setDownload(string fileId, string filePath)
        {
            _fileId = fileId;
            _filePath = filePath;
        }

        public string getName() { return uploadName; }

        public string getPath() { return uploadPath; }

        public string getFolderId() { return _FolderId; }

        public string uploadFile()
        {
            DriveService service = GoogleDrive.getService();
            var fileId = GoogleDrive.UploadFile(service, uploadName, uploadPath, _FolderId);
            AddDocument(tableName, fileId, reportDate);
            return uploadPath;
        }

        public static string downloadFile()
        {
            DriveService service = GoogleDrive.getService();
            GoogleDrive.DownloadFile(service, _fileId, _filePath);
            return _filePath;
        }
        #endregion

        public static void AddDocument(string table, string fileId, string date)
        {
            _data.AddRow(table, new string[] { "pathAddress", "dateCreated"}, new string[] { fileId, date});
        }

        public static void UpdateDocumentResponse(string table, string fileId)
        {
            _data.RemoveCriteria();
            _data.SetCriteria("reportID", fileId);
            _data.UpdateRowsByKey(table, new string[] { "responded" }, new string[] { "1" });
        }
        #endregion
    }
}
