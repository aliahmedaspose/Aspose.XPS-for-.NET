using Aspose.Xps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.WorkingWithDocumentConversion
{
    public class XPStoJPEG
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_WorkingWithDocumentConversion();
            // Load Existing XPS Document
            XpsDocument doc = new XpsDocument(dataDir + "input.xps");
            // Initialize JpegSaveOptions
            JpegSaveOptions jpegSaveOptions = new JpegSaveOptions();
            // Specify Resolution
            jpegSaveOptions.Resolution = 300f;
            // Save as JPEG Image
            doc.Save(dataDir + "XPStoImage_out.jpeg", jpegSaveOptions);
            // ExEnd:1
        }
    }
}
