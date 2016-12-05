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
    public class scrapNote
    {

        private DateTime dateTime = DateTime.UtcNow.Date;

        public scrapNote()
        {
            throw new System.NotImplementedException();
        }

       
        public scrapNote(string snNo, string custName, string custAdd, string ceAdd, string rgarNo, string text)
        {
            int Num = Convert.ToInt32(snNo);
            
            string curfile = "..\\..\\Reports\\CustomerServices\\Scrap Notes\\scrapNote" + snNo + ".pdf";
            Document doc = new Document(PageSize.A4, 36, 36, 10, 10);
            
            
            if (File.Exists(curfile) == true)
            {
                Num++;
                FileStream fs = new FileStream("..\\..\\Reports\\CustomerServices\\Scrap Notes\\scrapNote" + snNo + ".pdf", FileMode.Create, FileAccess.Write, FileShare.None);
                PdfWriter wr = PdfWriter.GetInstance(doc, fs);
                doc.Open();
            
            }
            else
            {
                FileStream fs = new FileStream("..\\..\\Reports\\CustomerServices\\Scrap Notes\\scrapNote" + snNo + ".pdf", FileMode.Create, FileAccess.Write, FileShare.None);
                PdfWriter wr = PdfWriter.GetInstance(doc, fs);
                doc.Open();
            }


            string newSn_No;
            newSn_No = Num.ToString();

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

            Paragraph sn = new Paragraph("\nScrap Note");
            sn.Alignment = Element.ALIGN_CENTER;
            doc.Add(sn);

            Paragraph sn_No = new Paragraph("No. " + newSn_No);
            sn_No.Alignment = Element.ALIGN_CENTER;
            doc.Add(sn_No);

            Paragraph to = new Paragraph("To: " + ceAdd);
            to.Alignment = Element.ALIGN_LEFT;
            doc.Add(to);

            Paragraph rgar = new Paragraph("Return Goods Authorisation Request Number: " + rgarNo);
            rgar.Alignment = Element.ALIGN_LEFT;
            doc.Add(rgar);

            Paragraph csName = new Paragraph("\nCustomer Name: " + custName);
            csName.Alignment = Element.ALIGN_LEFT;
            doc.Add(csName);

            Paragraph csAdd = new Paragraph("Customer Address: " + custAdd);
            csAdd.Alignment = Element.ALIGN_LEFT;
            doc.Add(csAdd);

            Paragraph msg = new Paragraph("\n\n" + text);
            msg.Alignment = Element.ALIGN_LEFT;
            doc.Add(msg);

            Paragraph sig = new Paragraph("\n\n__________________________________\nG. Lyons, Customer Services");
            sig.Alignment = Element.ALIGN_LEFT;
            doc.Add(sig);
    
            doc.Close();
            MessageBox.Show("Scrap Note Successfully Created!\n\nScrap Note No.: " + newSn_No + "\n\n" + "RGAR: " + rgarNo + "\nCustomer: " + custName);
            

            //doc.Add(Chunk.NEWLINE);

            //Paragraph txt = new Paragraph(text);
            //txt.Alignment = Element.ALIGN_LEFT;
            //doc.Add(txt);

            //doc.Add(Chunk.NEWLINE);

            //Chunk chunk = new Chunk("CUSTOM ITEMS", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12.0f, iTextSharp.text.Font.UNDERLINE));
            //Paragraph custItem = new Paragraph(chunk);
            //custItem.Alignment = Element.ALIGN_LEFT;
            //doc.Add(custItem);

            //doc.Add(Chunk.NEWLINE);

            //Phrase header1 = new Phrase("Line No.", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12.0f, iTextSharp.text.Font.BOLD));
            //Phrase header2 = new Phrase("Cust P/N", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12.0f, iTextSharp.text.Font.BOLD));
            //Phrase header3 = new Phrase("Quantity", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12.0f, iTextSharp.text.Font.BOLD));
            //PdfPTable items = new PdfPTable(3);
            //items.HorizontalAlignment = Element.ALIGN_LEFT;
            //items.AddCell(header1);
            //items.AddCell(header2);
            //items.AddCell(header3);
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
            //doc.Add(items);

            //doc.Add(Chunk.NEWLINE);
            //doc.Add(Chunk.NEWLINE);

            //Paragraph sig = new Paragraph("__________________________________\nPatrick G. Hynes, Sales Manager");
            //sig.Alignment = Element.ALIGN_LEFT;
            //doc.Add(sig);

            //doc.Close();



        }


    }
}
