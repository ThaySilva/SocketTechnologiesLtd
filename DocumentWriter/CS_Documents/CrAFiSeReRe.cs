using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace DocumentWriter
{
    public class CrAFiSeReRe
    {
        private DateTime dateTime = DateTime.UtcNow.Date;

        public CrAFiSeReRe()
        {
            throw new System.NotImplementedException();
        }

        public CrAFiSeReRe( string CustPurcOrdNum, string FSRLogNum, string CustName, string CustAddr, string text, string text1, string text2)
        {
            FileStream fs = new FileStream("..\\..\\Reports\\CustomerServices\\Field service request response\\CrAFiSeReRe"  + ".pdf", FileMode.Create, FileAccess.Write, FileShare.None);
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

            Paragraph CrAFiSeReRe = new Paragraph("\nService Request Response\n");
            CrAFiSeReRe.Alignment = Element.ALIGN_CENTER;
            doc.Add(CrAFiSeReRe);

            Paragraph CrAFiSeReReNo = new Paragraph("No. " );
            CrAFiSeReReNo.Alignment = Element.ALIGN_CENTER;
            doc.Add(CrAFiSeReReNo);

            Paragraph cust = new Paragraph("To: " + CustName + ",\n" + CustAddr);
            cust.Alignment = Element.ALIGN_LEFT;
            doc.Add(cust);

            doc.Add(Chunk.NEWLINE);

           

            PdfPTable table = new PdfPTable(2);
            float[] widths = new float[] { 180f, 60f };
            table.SetTotalWidth(widths);
            table.LockedWidth = true;
            table.HorizontalAlignment = Element.ALIGN_LEFT;
            table.AddCell("Customer Purchase Order Number:");
            table.AddCell(CustPurcOrdNum.ToString());
            doc.Add(table);

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

            Phrase header1 = new Phrase("Line No.", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12.0f, iTextSharp.text.Font.BOLD));
            Phrase header2 = new Phrase("Cust P/N", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12.0f, iTextSharp.text.Font.BOLD));
            Phrase header3 = new Phrase("Quantity", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12.0f, iTextSharp.text.Font.BOLD));
            PdfPTable items = new PdfPTable(3);
            items.HorizontalAlignment = Element.ALIGN_LEFT;
            items.AddCell(header1);
            items.AddCell(header2);
            items.AddCell(header3);
            //foreach (DataGridViewRow row in dataGrid.Rows)
            //{
            //    foreach (DataGridViewCell cell in row.Cells)
            //    {
            //        try
            //        {
            //            items.AddCell(cell.Value.ToString());
            //        }
            //        catch { }
            //    }
            //}
            doc.Add(items);

            doc.Add(Chunk.NEWLINE);
            doc.Add(Chunk.NEWLINE);

            Paragraph sig = new Paragraph("__________________________________\nPatrick G. Hynes, Sales Manager");
            sig.Alignment = Element.ALIGN_LEFT;
            doc.Add(sig);

            doc.Close();
        }
    }
}
