using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYPUrduCompiler
{
    class CharMap
    {
       
        private Range range;
        private Workbook xlworkBook;
        private Worksheet xlWorkSheet;
        private int rCnt;
        private int cCnt;
        private int rw = 0;
        private int cl = 0;

        Dictionary<string, string> hashMap = new Dictionary<string, string>();
        Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
        PathConfigs paths = new PathConfigs();
        public CharMap()
        {
            xlworkBook = excel.Workbooks.Open(paths.dbPath+paths.dbSheet, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            xlWorkSheet = (Worksheet)xlworkBook.Worksheets.get_Item(1);
            range = xlWorkSheet.UsedRange;
            rw = range.Rows.Count;
            cl = range.Columns.Count;
            String key;
            String value;

            for (rCnt = 1; rCnt <= rw; rCnt++)
            {
                key= Convert.ToString((range.Cells[rCnt, 1] as Range).Value2);
                value = Convert.ToString((range.Cells[rCnt, 2] as Range).Value2);
                hashMap.Add(key, value);
            }
            xlworkBook.Close(true, null, null);
            excel.Quit();

            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlworkBook);
            Marshal.ReleaseComObject(excel);          
        }

        public string convertUniCode(char uni)
        {
            
            if (hashMap.ContainsKey(uni.ToString()))
                return hashMap[uni.ToString()];
            else
                return "  ";
        }
    }
}
