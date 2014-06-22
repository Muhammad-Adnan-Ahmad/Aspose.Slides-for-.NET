//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Slides. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Slides;

namespace AccessingOLEObjectFrame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            //Load the PPTX to Presentation object
            Presentation pres = new Presentation(dataDir+ "OleEmbed.pptx");

            //Access the first slide
            ISlide sld = pres.Slides[0];

            //Cast the shape to OleObjectFrame
            OleObjectFrame oof = (OleObjectFrame)sld.Shapes[0];

            //Read the OLE Object and write it to disk
            if (oof != null)
            {
                FileStream fstr = new FileStream(dataDir+ "excelFromOLE.xlsx", FileMode.Create, FileAccess.Write);
                byte[] buf = oof.ObjectData;
                fstr.Write(buf, 0, buf.Length);
                fstr.Flush();
                fstr.Close();
            }
            
            
        }
    }
}