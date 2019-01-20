using Aspose.Xps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.WorkingWithDocumentConversion
{
    public class XPStoPNG
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_WorkingWithDocumentConversion();
            // Load Existing XPS Document
            XpsDocument doc = new XpsDocument(dataDir + "input.xps");
            // Initialize PngSaveOptions
            PngSaveOptions pngSaveOptions = new PngSaveOptions();
            // Specify Resolution
            pngSaveOptions.Resolution = 300f;
            // Save as PNG Image
            doc.Save(dataDir + "XPStoImage_out.png", pngSaveOptions);
            // ExEnd:1
        }
    }
}
