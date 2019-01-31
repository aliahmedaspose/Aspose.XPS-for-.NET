using Aspose.Xps;

namespace CSharp.WorkingWithDocumentConversion
{
    public class XPStoPDF
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_WorkingWithDocumentConversion();
            // Load Existing XPS Document
            XpsDocument doc = new XpsDocument(dataDir + "input.xps");
            // Initialize PdfSaveOptions
            PdfSaveOptions pdfSaveOptions = new PdfSaveOptions();
            // Specify TextCompression Style 
            pdfSaveOptions.TextCompression = PdfTextCompression.Flate;
            // Save as PDF Document
            doc.Save(dataDir + "XPStoPDF_out.pdf", pdfSaveOptions);
            // ExEnd:1
        }
    }
}
