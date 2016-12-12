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
        private static DriveService service = new DriveService();
        private static string uploadName;
        private static string uploadPath;
        private static string _FolderId;
        private static string tableName;
        private static string reportDate;


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

        #region Set Upload Functions
        public static void setUpload(string name, string path, string FolderId)
        {
            service = GoogleDrive.getService();
            uploadName = name;
            uploadPath = path;
            _FolderId = FolderId;

        }

        public static void setDatabaseUpload(string table, string date)
        {
            tableName = table;
            reportDate = date;
        }

        public string getName() { return uploadName; }

        public string getPath() { return uploadPath; }

        public string getFolderId() { return _FolderId; }

        public string uploadFile()
        {
            var fileId = GoogleDrive.UploadFile(service, uploadName, uploadPath, _FolderId);
            AddDocument(tableName, fileId, reportDate);
            return uploadPath;
        }
        #endregion

        public static void AddDocument(string table, string fileId, string date)
        {
            _data.AddRow(table, new string[] { "pathAddress", "dateCreated"}, new string[] { fileId, date});
        }
        #endregion
    }
}
