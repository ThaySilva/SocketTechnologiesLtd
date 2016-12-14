using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using BusinessEntities;
using BusinessLayer;

namespace DocumentWriter
{
    public class RfQ
    {
        private DateTime dateTime = DateTime.UtcNow.Date;
        int i = 0;

        public RfQ()
        {
            throw new System.NotImplementedException();
        }

        public RfQ(string id, Customer customer, List<IProduct> standardParts, int[] standarQty, List<IProduct> customParts, string[] requiredDates, string contact)
        {
            string name = "RfQ" + id + ".pdf";
            string path = "..\\..\\Reports\\" + name;

            iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4, 36, 36, 10, 10);
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None);
            PdfWriter wr = PdfWriter.GetInstance(doc, fs);

            doc.Open();

            Paragraph date = new Paragraph(dateTime.ToString("dd/MM/yyyy"));
            date.Alignment = Element.ALIGN_RIGHT;
            doc.Add(date);

            Paragraph custAdd = new Paragraph(customer.CustCompanyName + ",\n" + customer.CustAddress[0] + ",\n" + customer.CustAddress[1] + ",\n" + customer.CustAddress[2]);
            custAdd.Alignment = Element.ALIGN_CENTER;
            doc.Add(custAdd);

            Paragraph rfq = new Paragraph("\nRequest for Quotation\n");
            rfq.Alignment = Element.ALIGN_CENTER;
            doc.Add(rfq);

            Paragraph rfqNo = new Paragraph("No. " + id);
            rfqNo.Alignment = Element.ALIGN_CENTER;
            doc.Add(rfqNo);

            Paragraph stl = new Paragraph("To: Socket Technologies Ltd.,\nRaheen Industrial Estate,\nLimerick");
            stl.Alignment = Element.ALIGN_LEFT;
            doc.Add(stl);

            doc.Add(Chunk.NEWLINE);

            Paragraph p1 = new Paragraph("Please quote for the supply of the following standard STL parts:");
            p1.Alignment = Element.ALIGN_LEFT;
            doc.Add(p1);

            doc.Add(Chunk.NEWLINE);

            Chunk chunk = new Chunk("STANDARD ITEMS", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12.0f, iTextSharp.text.Font.UNDERLINE));
            Paragraph standItem = new Paragraph(chunk);
            standItem.Alignment = Element.ALIGN_LEFT;
            doc.Add(standItem);

            doc.Add(Chunk.NEWLINE);

            PdfPTable table = new PdfPTable(3);
            float[] widths = new float[] { 180f, 180f, 180f };
            table.SetTotalWidth(widths);
            table.LockedWidth = true;
            table.HorizontalAlignment = Element.ALIGN_LEFT;
            table.AddCell("STL P/N.");
            table.AddCell("Part Name");
            table.AddCell("Quantity");
            foreach(Product prod in standardParts)
            {
                table.AddCell(prod.ProductId.ToString());
                table.AddCell(prod.ProductName);
                table.AddCell(standarQty[i].ToString());
                i++;
            }
            doc.Add(table);

            doc.Add(Chunk.NEWLINE);

            Paragraph p2 = new Paragraph("Please quote for the supply of the following custom parts");
            p2.Alignment = Element.ALIGN_LEFT;
            doc.Add(p2);

            doc.Add(Chunk.NEWLINE);

            Chunk chunk2 = new Chunk("CUSTOM ITEMS", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12.0f, iTextSharp.text.Font.UNDERLINE));
            Paragraph custItem = new Paragraph(chunk2);
            custItem.Alignment = Element.ALIGN_LEFT;
            doc.Add(custItem);

            doc.Add(Chunk.NEWLINE);

            PdfPTable table2 = new PdfPTable(3);
            float[] widths2 = new float[] { 180f, 180f, 180f };
            table2.SetTotalWidth(widths2);
            table2.LockedWidth = true;
            table2.HorizontalAlignment = Element.ALIGN_LEFT;
            table2.AddCell("Custom Part Name");
            table2.AddCell("Specifications");
            table2.AddCell("Quantity");
            foreach(Product custom in customParts)
            {
                table2.AddCell(custom.ProductName);
                table2.AddCell(custom.ProductDescription);
                table2.AddCell(custom.Quantity.ToString());
            }
            doc.Add(table2);

            doc.Add(Chunk.NEWLINE);

            Paragraph p3 = new Paragraph("Standard conditions apply.");
            p3.Alignment = Element.ALIGN_LEFT;
            doc.Add(p3);

            doc.Add(Chunk.NEWLINE);

            Paragraph qDate = new Paragraph("Quotation required by " + requiredDates[0]);
            qDate.Alignment = Element.ALIGN_LEFT;
            doc.Add(qDate);

            doc.Add(Chunk.NEWLINE);

            Paragraph dates = new Paragraph("Delivery required:\n\t\t" + requiredDates[1] + " days from submission of order for custom items.\n\t\t" + requiredDates[2] + " days from submission for standard items.");
            dates.Alignment = Element.ALIGN_LEFT;
            doc.Add(dates);

            doc.Add(Chunk.NEWLINE);
            doc.Add(Chunk.NEWLINE);

            Paragraph sig = new Paragraph("__________________________________\n" + contact);
            sig.Alignment = Element.ALIGN_LEFT;
            doc.Add(sig);

            doc.Close();

            string FolderId = "0B_ob9qFmHlBcc2tiS2p6bWlEMlE";

            Common_Rules.setPdf("Request for Quotation " + id, path);

            Common_Rules.setUpload(name, path, FolderId);

            Common_Rules.setDatabaseUpload("RequestForQuotation_Report", dateTime.ToShortDateString());
        }
    }
}
