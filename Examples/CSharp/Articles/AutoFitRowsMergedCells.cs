using System.IO;
using Aspose.Cells;
using System;
namespace Aspose.Cells.Examples.CSharp.Articles
{
    public class AutoFitRowsMergedCells
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            // Create directory if it is not already present.
            bool IsExists = System.IO.Directory.Exists(dataDir);
            if (!IsExists)
                System.IO.Directory.CreateDirectory(dataDir);

            // Instantiate a new Workbook
            Workbook wb = new Workbook();

            // Get the first (default) worksheet
            Worksheet _worksheet = wb.Worksheets[0];

            // Create a range A1:B1
            Range range = _worksheet.Cells.CreateRange(0, 0, 1, 2);

            // Merge the cells
            range.Merge();

            // Insert value to the merged cell A1
            _worksheet.Cells[0, 0].Value = "A quick brown fox jumps over the lazy dog. A quick brown fox jumps over the lazy dog....end";

            // Create a style object
            Aspose.Cells.Style style = _worksheet.Cells[0, 0].GetStyle();

            // Set wrapping text on
            style.IsTextWrapped = true;

            // Apply the style to the cell
            _worksheet.Cells[0, 0].SetStyle(style);

            // Create an object for AutoFitterOptions
            AutoFitterOptions options = new AutoFitterOptions();

            // Set auto-fit for merged cells
            options.AutoFitMergedCells = true;

            // Autofit rows in the sheet(including the merged cells)
            _worksheet.AutoFitRows(options);

            dataDir = dataDir + "AutoFitMergedCells.out.xlsx";
            // Save the Excel file
            wb.Save(dataDir);
            // ExEnd:1
            Console.WriteLine("\nProcess completed successfully.\nFile saved at " + dataDir);
            
        }
    }
}
