using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;       //microsoft Excel 14 object in references-> COM tab

namespace Codetesting
{
    public class Program
    {
        public static List<double> F1List = new List<double>();
        public static List<string> F2List = new List<string>();
        public static List<double> F3List = new List<double>();


 static void Main(string[] args)

        {
            getExcelFile();

 }
        public static void getExcelFile()
        {
         double[] focallength1 = new double[3] ; // Initialize array for focakl length 1
         double[] focallength2 = new double[3] ; // Initialize array for focal length 2
        double[] focallength3 = new double[3] ; //Initialize array for focal length 3

            //Create COM Objects. Create a COM object for everything that is referenced
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"C:\Users\Ali\Source\Repos\New-Code-Test-Repo\Codetesting\Codetesting\focal.xlsx");
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;            

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;

            List<string> mlstColumn = new List<string>();

            // get used range of column F
            Excel.Range F1range = xlWorksheet.UsedRange.Columns["A", Type.Missing];
            Excel.Range F2range = xlWorksheet.UsedRange.Columns["B", Type.Missing];
            // get number of used rows in column F
            int F1rngCount = F1range.Rows.Count;
            int F2rngCount = F2range.Rows.Count;

            // iterate over column F's used row count and store values to the list
            for (int i = 1; i <= F1rngCount; i++)
            {
                F1List.Add(xlWorksheet.Cells[i, "A"].Value);
            }

            for (int j = 1; j <= F2rngCount; j++)
            {
                F2List.Add(xlWorksheet.Cells[j, "B"].Value.ToString());
            }



            for (int x = 0; x < F1List.Count; x++)
            {
                Console.WriteLine(F1List[x]);

            }

            for (int y = 0; y < F2List.Count; y++)
            {
                Console.WriteLine(F2List[y]);

            } 


                // remember to Quit() or the instance of Excel will keep running in the background
                //int f1 = 0;
                //int f2 = 0;

                //iterate over the rows and columns and print to the console as it appears in the file
                //excel is not zero based!!
                //for (int j = 1; j <= colCount; j++)
                //{
                //    for (int i = 1; i <= rowCount; i++)
                //    {
                //        //new line
                //        if (i == 1)
                //            Console.Write("\r\n");

                //        //write the value to the console
                //        if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)


                //            Console.Write(xlRange.Cells[i,j].Value2.ToString() + "\n");
                //    }
                //}

                //cleanup
                GC.Collect();
            GC.WaitForPendingFinalizers();

            //rule of thumb for releasing com objects:
            //  never use two dots, all COM objects must be referenced and released individually
            //  ex: [somthing].[something].[something] is bad

            //release com objects to fully kill excel process from running in the background
            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);

            //close and release
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);

            //quit and release
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
        
        }
    }
}