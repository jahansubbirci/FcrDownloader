using iTextSharp.text.pdf.parser;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FcrDownloader
{
    public class FcrReader
    {
        public KeyValuePair<string, string> Read(string fileName)
        {


            PdfReader pdfReader = new PdfReader(fileName);
            ITextExtractionStrategy strategy = new BlockTextExtractionStrategy();

            string currentText = PdfTextExtractor.GetTextFromPage(pdfReader, 1, strategy);
            var array=currentText.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            var fcrNo = array[6].Trim();
            var pair=new KeyValuePair<string, string>(fileName,fcrNo);
            pdfReader.Close();
            return pair;
        }
    }
}
