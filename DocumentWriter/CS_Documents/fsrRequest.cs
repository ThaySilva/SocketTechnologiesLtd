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


namespace DocumentWriter
{
    public class fsrRequest
    {

        private DateTime dateTime = DateTime.UtcNow.Date;

        public fsrRequest()
        {
            throw new System.NotImplementedException();
        }


        public fsrRequest(string fsrID, string custID, string cpoID, string text, string type)
        {
            Document doc = new Document(PageSize.A4, 36, 36, 10, 10);
            byte[] pdfBytes;
            string newfsr_No;

            using (MemoryStream mem = new MemoryStream())
            {
                using (PdfWriter writer = PdfWriter.GetInstance(doc, mem))
                {
                    int Num = Convert.ToInt32(fsrID);

                    doc.Open();
            
                    newfsr_No = Num.ToString();

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

                    Paragraph fsr = new Paragraph("\nField Service Request");
                    fsr.Alignment = Element.ALIGN_CENTER;
                    doc.Add(fsr);

                    Paragraph fsr_id = new Paragraph("FSR ID:  " + newfsr_No);
                    fsr_id.Alignment = Element.ALIGN_CENTER;
                    doc.Add(fsr_id);

                    Paragraph id = new Paragraph("\n\nCustomer ID: " + custID);
                    id.Alignment = Element.ALIGN_LEFT;
                    doc.Add(id);

                    Paragraph cpo = new Paragraph("Customer Purchase Order ID: " + cpoID);
                    cpo.Alignment = Element.ALIGN_LEFT;
                    doc.Add(cpo);

                    Paragraph fsrtype = new Paragraph("Field Service Request Type: " + type);
                    fsrtype.Alignment = Element.ALIGN_LEFT;
                    doc.Add(fsrtype);

                    Paragraph fsrtxt = new Paragraph("\n\nText: \n" + text);
                    fsrtxt.Alignment = Element.ALIGN_LEFT;
                    doc.Add(fsrtxt);


                    Paragraph sig = new Paragraph("\n\n__________________________________\nG. Lyons, Customer Services");
                    sig.Alignment = Element.ALIGN_LEFT;
                    doc.Add(sig);

                    doc.Close();
                }
                pdfBytes = mem.ToArray();
            }
                MessageBox.Show("FSR request Successfully Created!\n\nFSR Request ID: " + newfsr_No);

                DriveService service = GoogleDrive.getService();

                var fileId = GoogleDrive.UploadFile(service, "FSRrequest1.pdf", pdfBytes);

                MessageBox.Show(fileId);

            GoogleDrive.DownloadFile(service, fileId, @"C:\Users\Sinea\Documents\FSRrequest1.pdf");


            
        }
    }
}
