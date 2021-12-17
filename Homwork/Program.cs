using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;


namespace Homwork
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 2");
            try
            {
                Application excel = new Application();
                Workbook workbook = excel.Workbooks.Open($"{Environment.CurrentDirectory}\\1. Болезни.xlsx");
                Worksheet worksheet = workbook.Worksheets[1];
                object[,] readRange = worksheet.Range["A2", "B10"].Value2;
                Dictionary<string, string> deseases = new Dictionary<string, string>();
                for (int i = 1; i <= readRange.GetLength(0); i++)
                {
                    deseases.Add(readRange[i, 1].ToString().ToLower(), readRange[i, 2].ToString());
                }
                workbook.Close();
                workbook = excel.Workbooks.Open($"{Environment.CurrentDirectory}\\2. Общее.xlsx");
                worksheet = workbook.Worksheets[1];
                readRange = worksheet.Range["G2", "G35"].Value2;
                for (int i = 1; i <= readRange.Length; i++)
                {
                    string readString = readRange[i, 1].ToString().ToLower();
                    foreach (var desease in deseases)
                    {
                        if (readString.Contains(desease.Key))
                        {
                            readRange[i, 1] = desease.Value;
                            break;
                        }
                    }
                }
                worksheet.Range["H2", "H35"].Value2 = readRange;
                workbook.Save();
                workbook.Close();
                excel.Quit();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
