using Aspose.Xps;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CSharp.WorkingWithDocumentConversion
{
    public class XPStoPDFStream
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_WorkingWithDocumentConversion();
            // Load Existing XPS Document
            XpsDocument doc = new XpsDocument(dataDir + "input.xps");
            // Initialize PdfSaveOptions
            PdfSaveOptions pdfSaveOptions = new PdfSaveOptions
            {
                // Specify TextCompression Style 
                TextCompression = PdfTextCompression.Flate
            };
            //Create a PDF stream
            FileStream outputStream = new FileStream(dataDir + "XPStoPDF_out.pdf", FileMode.OpenOrCreate);
            // Save as PDF Document
            doc.Save(outputStream, pdfSaveOptions);
            // ExEnd:1
        }
    }
}
