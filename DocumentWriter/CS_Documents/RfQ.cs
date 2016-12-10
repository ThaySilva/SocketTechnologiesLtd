using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace DocumentWriter.CS_Documents
{
    public class RfQ
    {
        private DateTime dateTime = DateTime.UtcNow.Date;
        int id = 1;
        string path;

        public RfQ()
        {
            throw new System.NotImplementedException();
        }

        public RfQ(Customer custDetails, Product standardProd)
        {
            path = "..\\..\\Reports\\CustomerServices\\Request for Quotation\\RfQ" + id + ".pdf";

            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None);
            Document doc = new Document(PageSize.A4, 36, 36, 10, 10);
            PdfWriter writer = PdfWriter.GetInstance(doc, fs);
            doc.Open();

            Paragraph date = new Paragraph(dateTime.ToString("dd/MM/yyyy"));
            date.Alignment = Element.ALIGN_RIGHT;
            doc.Add(date);

            Paragraph customer = new Paragraph(custDetails.CustCompanyName + "\n" + custDetails.CustAddress[0] + "\n" + custDetails.CustAddress[1] + "\n" + custDetails.CustAddress[2]);
            customer.Alignment = Element.ALIGN_CENTER;
            doc.Add(customer);

            doc.Add(Chunk.NEWLINE);

            Paragraph rfq = new Paragraph("Request for Quotation\nNo. ");

        }
    }
}