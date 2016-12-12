using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Document : IDocument
    {
        #region Instance Properties
        private int docId;
        private string docPath;
        private DateTime dateCreated;
        #endregion

        #region Instance Properties
        public int DocumentID
        {
            get { return docId; }
            set { docId = value; }
        }

        public string DocumentPath
        {
            get { return docPath; }
            set { docPath = value; }
        }

        public DateTime DateCreated
        {
            get { return dateCreated; }
            set { dateCreated = value; }
        }
        #endregion

        #region Constructors
        public Document()
        {
            throw new System.NotImplementedException();
        }

        public Document(int Id, string path, DateTime date)
        {
            this.docId = Id;
            this.docPath = path;
            this.dateCreated = date;
        }
        #endregion
    }
}
