using Aspose.Xps;
using Aspose.Xps.XpsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.WorkingWithPages
{
    public class AddRemovePage
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_WorkingWithPages();
            // Create new XPS Document
            XpsDocument doc = new XpsDocument(dataDir + "Sample1.xps");

            // Get 5th path
            XpsPath path = (XpsPath)doc.Page[5];
            // Remove 5th canvas
            doc.RemoveAt(5);

            // Insert an empty page before the first one
            doc.InsertPage(1, true);
            // Add saved path to the new page
            doc.Add(path);
            
            // Save resultant XPS document
            doc.Save(dataDir + "WorkingWithPages_out.xps");
            // ExEnd:1
        }
    }
}
