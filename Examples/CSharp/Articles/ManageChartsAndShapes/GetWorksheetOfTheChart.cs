﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aspose.Cells.Charts;

namespace Aspose.Cells.Examples.CSharp.Articles.ManageChartsAndShapes
{
    public class GetWorksheetOfTheChart
    {
        public static void Run()
        {
            // ExStart:GetWorksheetOfTheChart
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            // Create workbook from sample Excel file
            Workbook workbook = new Workbook(dataDir + "sample.xlsx");

            // Access first worksheet of the workbook
            Worksheet worksheet = workbook.Worksheets[0];

            // Print worksheet name
            Console.WriteLine("Sheet Name: " + worksheet.Name);

            // Access the first chart inside this worksheet
            Chart chart = worksheet.Charts[0];

            // Access the chart's sheet and display its name again
            Console.WriteLine("Chart's Sheet Name: " + chart.Worksheet.Name);
            // ExEnd:GetWorksheetOfTheChart
        }
    }
}
