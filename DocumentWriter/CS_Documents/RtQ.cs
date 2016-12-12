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
    public class RtQ
    {
        private DateTime dateTime = DateTime.UtcNow.Date;

        public RtQ()
        {
            throw new System.NotImplementedException();
        }

        public RtQ(string id, string custName, string custAdd, string RfQId, string text, DataGridView dataGrid)
        {
            string name = "RtQ" + id + ".pdf";
            string path = "..\\..\\Reports\\" + name;

            Document doc = new Document(PageSize.A4, 36, 36, 10, 10);
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None);
            PdfWriter wr = PdfWriter.GetInstance(doc, fs);

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

            Paragraph rtq = new Paragraph("\nRefusal to Quote\n");
            rtq.Alignment = Element.ALIGN_CENTER;
            doc.Add(rtq);

            Paragraph rtqNo = new Paragraph("No. " + id);
            rtqNo.Alignment = Element.ALIGN_CENTER;
            doc.Add(rtqNo);

            Paragraph cust = new Paragraph("To: " + custName + ",\n" + custAdd);
            cust.Alignment = Element.ALIGN_LEFT;
            doc.Add(cust);

            doc.Add(Chunk.NEWLINE);

            Paragraph attn = new Paragraph("ATTN: M.Gillis, Purchasing Manager");
            attn.Alignment = Element.ALIGN_LEFT;
            doc.Add(attn);

            doc.Add(Chunk.NEWLINE);

            PdfPTable table = new PdfPTable(2);
            float[] widths = new float[] { 180f, 60f };
            table.SetTotalWidth(widths);
            table.LockedWidth = true;
            table.HorizontalAlignment = Element.ALIGN_LEFT;
            table.AddCell("Request for Quotation Number:");
            table.AddCell(RfQId.ToString());
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
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    try
                    {
                        items.AddCell(cell.Value.ToString());
                    }
                    catch { }
                }
            }
            doc.Add(items);

            doc.Add(Chunk.NEWLINE);
            doc.Add(Chunk.NEWLINE);

            Paragraph sig = new Paragraph("__________________________________\nPatrick G. Hynes, Sales Manager");
            sig.Alignment = Element.ALIGN_LEFT;
            doc.Add(sig);

            doc.Close();

            string FolderId = "0B_ob9qFmHlBcMHNVSDB3YXZ5YkE";

            Common_Rules.setPdf("Refusal to Quote " + id, path);

            Common_Rules.setUpload(name, path, FolderId);

            Common_Rules.setDatabaseUpload("RefusalToQuote_Report", dateTime.ToShortDateString());       
        }
    }
}
