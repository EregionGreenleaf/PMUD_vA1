using Excel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test01
{
    class ExcelReader
    {
        private string File;
        public ExcelReader(string file)
        {
            File = file;
        }

        public IEnumerable<worksheet> GetWorksheet()
        {
            return Workbook.Worksheets(File);
        }
    }
}
