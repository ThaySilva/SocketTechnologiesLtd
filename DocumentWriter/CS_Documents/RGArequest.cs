using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Forms;

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
            int Num = Convert.ToInt32(rgaID);

            string curfile = "..\\..\\Reports\\CustomerServices\\RGA Requests\\RGArequest" + rgaID + ".pdf";
            Document doc = new Document(PageSize.A4, 36, 36, 10, 10);


            if (File.Exists(curfile) == true)
            {
                Num++;
                FileStream fs = new FileStream("..\\..\\Reports\\CustomerServices\\RGA Requests\\RGArequest" + Num + ".pdf", FileMode.Create, FileAccess.Write, FileShare.None);
                PdfWriter wr = PdfWriter.GetInstance(doc, fs);
                doc.Open();

            }
            else
            {
                FileStream fs = new FileStream("..\\..\\Reports\\CustomerServices\\RGA Requests\\RGArequest" + rgaID + ".pdf", FileMode.Create, FileAccess.Write, FileShare.None);
                PdfWriter wr = PdfWriter.GetInstance(doc, fs);
                doc.Open();
            }


            string newrga_No;
            newrga_No = Num.ToString();

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

            Paragraph rga_id = new Paragraph("RGA ID:  " + newrga_No);
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
            MessageBox.Show("RGA request Successfully Created!\n\nRGA Request ID: " + newrga_No);


        }
    }
}
