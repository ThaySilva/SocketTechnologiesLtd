using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.Windows.Forms;

namespace DocumentWriter
{
    public class Pdf_Reader
    {
        public Pdf_Reader()
        {

        }


        public string readPdf(string filePath)
        {
            string text = string.Empty;
            try
            {
                PdfReader reader = new PdfReader(filePath);

                for(int page = 1; page <= reader.NumberOfPages; page++)
                {
                    ITextExtractionStrategy its = new LocationTextExtractionStrategy();
                    String s = PdfTextExtractor.GetTextFromPage(reader, page, its);

                    s = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(s)));
                    text = text + s;
                }
                reader.Close();
                File.Delete(filePath);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return null;
            }

            return text;
        }
    }
}
