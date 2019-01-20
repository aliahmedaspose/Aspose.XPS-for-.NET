using Aspose.Xps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.WorkingWithDocumentConversion
{
    public class XPStoTIFF
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_WorkingWithDocumentConversion();
            // Load Existing XPS Document
            XpsDocument doc = new XpsDocument(dataDir + "input.xps");
            // Initialize TiffSaveOptions
            TiffSaveOptions tiffSaveOptions = new TiffSaveOptions();
            // Specify Resolution
            tiffSaveOptions.Resolution = 300f;
            // Save as TIFF Image
            doc.Save(dataDir + "XPStoImage_out.tif", tiffSaveOptions);
            // ExEnd:1
        }
    }
}
