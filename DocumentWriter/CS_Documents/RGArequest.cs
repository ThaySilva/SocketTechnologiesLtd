using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Forms;
using BusinessLayer;

namespace DocumentWriter
{
    public class RGArequest
    {
        private DateTime dateTime = DateTime.UtcNow.Date;

        public RGArequest()
        {
            throw new System.NotImplementedException();
        }


        public RGArequest(string rgaID, string custName, string custID, string cpoID, string text)
        {
            string fileName = "RGArequest" + rgaID + ".pdf";
            string path = "..\\..\\Reports\\" + fileName;


            Document doc = new Document(PageSize.A4, 36, 36, 10, 10);



            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None);
            PdfWriter wr = PdfWriter.GetInstance(doc, fs);
            doc.Open();

            Paragraph date = new Paragraph("Date: " + dateTime.ToString("dd/MM/yyyy"));
            date.Alignment = Element.ALIGN_RIGHT;
            doc.Add(date);

            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance("..\\..\\images\\Logo.png");
            img.ScalePercent(80f);
            img.Alignment = Element.ALIGN_CENTER;
            doc.Add(img);

            Paragraph stlAdd = new Paragraph("Socket Technologies Ltd.,\nRaheen Industrial Estate,\nLimerick");
            stlAdd.Alignment = Element.ALIGN_CENTER;
            doc.Add(stlAdd);

            Paragraph rga = new Paragraph("\nReturned Goods Authorisation Request");
            rga.Alignment = Element.ALIGN_CENTER;
            doc.Add(rga);

            Paragraph rga_id = new Paragraph("RGA ID:  " + rgaID);
            rga_id.Alignment = Element.ALIGN_CENTER;
            doc.Add(rga_id);

            Paragraph id = new Paragraph("\n\nCustomer ID: " + custID);
            id.Alignment = Element.ALIGN_LEFT;
            doc.Add(id);

            Paragraph cpo = new Paragraph("Customer Purchase Order ID: " + cpoID);
            cpo.Alignment = Element.ALIGN_LEFT;
            doc.Add(cpo);

            Paragraph fsrtype = new Paragraph("Customer Name: " + custName);
            fsrtype.Alignment = Element.ALIGN_LEFT;
            doc.Add(fsrtype);

            Paragraph fsrtxt = new Paragraph("\n\nText: \n" + text);
            fsrtxt.Alignment = Element.ALIGN_LEFT;
            doc.Add(fsrtxt);


            Paragraph sig = new Paragraph("\n\n__________________________________\nG. Lyons, Customer Services");
            sig.Alignment = Element.ALIGN_LEFT;
            doc.Add(sig);

            doc.Close();
            MessageBox.Show("RGA request Successfully Created!\n\nRGA Request ID: " + rgaID);

            string FolderId = "0B_ob9qFmHlBccjA1RmRBWGNnOG8";

            Common_Rules.setPdf("Returned Goods Authorisation Request " + rgaID, path);

            Common_Rules.setUpload(fileName, path, FolderId);

            Common_Rules.setDatabaseUpload("RGArequest_Report", dateTime.ToShortDateString());

        }
    }
}
