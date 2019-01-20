using Aspose.Xps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.WorkingWithDocumentConversion
{
    public class XPStoBMP
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_WorkingWithDocumentConversion();
            // Load Existing XPS Document
            XpsDocument doc = new XpsDocument(dataDir + "input.xps");
            // Initialize BmpSaveOptions
            BmpSaveOptions bmpSaveOptions = new BmpSaveOptions();
            // Specify Resolution
            bmpSaveOptions.Resolution = 300f;
            // Save as BMP Image
            doc.Save(dataDir + "XPStoImage_out.bmp", bmpSaveOptions);
            // ExEnd:1
        }
    }
}
