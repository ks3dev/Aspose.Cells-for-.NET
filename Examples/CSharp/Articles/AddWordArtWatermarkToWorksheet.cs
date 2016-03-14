using System.IO;

using Aspose.Cells;
using Aspose.Cells.Drawing;

namespace Aspose.Cells.Examples.Articles
{
    public class AddWordArtWatermarkToWorksheet
    {
        public static void Main(string[] args)
        {
            //ExStart:1
            // The path to the documents directory.
            string dataDir = Aspose.Cells.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            // Create directory if it is not already present.
            bool IsExists = System.IO.Directory.Exists(dataDir);
            if (!IsExists)
                System.IO.Directory.CreateDirectory(dataDir);

            //Instantiate a new Workbook
            Workbook workbook = new Workbook();

            //Get the first default sheet
            Worksheet sheet = workbook.Worksheets[0];

            //Add Watermark
            Aspose.Cells.Drawing.Shape wordart = sheet.Shapes.AddTextEffect(MsoPresetTextEffect.TextEffect1,
            "CONFIDENTIAL", "Arial Black", 50, false, true
            , 18, 8, 1, 1, 130, 800);

            //Get the fill format of the word art
            MsoFillFormat wordArtFormat = wordart.FillFormat;

            //Set the color
            wordArtFormat.ForeColor = System.Drawing.Color.Red;

            //Set the transparency
            wordArtFormat.Transparency = 0.9;

            //Make the line invisible
            MsoLineFormat lineFormat = wordart.LineFormat;
            lineFormat.IsVisible = false;

            //Save the file
            workbook.Save(dataDir+ "Watermark_Test.out.xls");
            //ExEnd:1
            
            
        }
    }
}
