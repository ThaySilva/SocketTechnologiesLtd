using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using BusinessLayer;


namespace DocumentWriter
{
    class AuthorisationResponseReport
    {
        private DateTime dateTime = DateTime.UtcNow.Date;

        public AuthorisationResponseReport(string departement, string text)
        {
            FileStream fs = new FileStream("..\\..\\Reports\\Management\\Authorisation request response\\AuthorisationResponseReport" + ".pdf", FileMode.Create, FileAccess.Write, FileShare.None);
            Document doc = new Document(PageSize.A4, 36, 36, 10, 10);
            PdfWriter writer = PdfWriter.GetInstance(doc, fs);
            doc.Open();

            Paragraph date = new Paragraph(dateTime.ToString("dd/MM/yyyy"));
            date.Alignment = Element.ALIGN_RIGHT;
            doc.Add(date);

            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance("..\\..\\images\\Logo.png");
            img.ScalePercent(80f);
            img.Alignment = Element.ALIGN_CENTER;
            doc.Add(img);

            Paragraph stlAdd = new Paragraph("Socket Technologies Ltd.,\nRaheen Industrial Estate,\nLimerick");
            stlAdd.Alignment = Element.ALIGN_CENTER;
            doc.Add(stlAdd);

            Paragraph ARR = new Paragraph("\nAuthorisation request response\n");
            ARR.Alignment = Element.ALIGN_CENTER;
            doc.Add(ARR);

            Paragraph CrAFiSeReReNo = new Paragraph("No. ");
            CrAFiSeReReNo.Alignment = Element.ALIGN_CENTER;
            doc.Add(CrAFiSeReReNo);

            Paragraph cust = new Paragraph("To: " + departement);
            cust.Alignment = Element.ALIGN_LEFT;
            doc.Add(cust);

            doc.Add(Chunk.NEWLINE);





            doc.Add(Chunk.NEWLINE);

            Paragraph txt = new Paragraph(text);
            txt.Alignment = Element.ALIGN_LEFT;
            doc.Add(txt);

            doc.Add(Chunk.NEWLINE);

            Chunk chunk = new Chunk("CUSTOM ITEMS", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12.0f, iTextSharp.text.Font.UNDERLINE));
            Paragraph custItem = new Paragraph(chunk);
            custItem.Alignment = Element.ALIGN_LEFT;
            doc.Add(custItem);

            doc.Add(Chunk.NEWLINE);



            doc.Add(Chunk.NEWLINE);
            doc.Add(Chunk.NEWLINE);

            Paragraph sig = new Paragraph("__________________________________\nPatrick G. Hynes, Sales Manager");
            sig.Alignment = Element.ALIGN_LEFT;
            doc.Add(sig);

            doc.Close();
        }
    }


}



