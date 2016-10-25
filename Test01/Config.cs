using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test01
{
    public class Config
    {
        public static string FileLoc { get; } = @"C:\UTIL_EXTRA";
        public static string FileName { get; } = "Test.xls";
        public static string FileCompleto { get; } = String.Concat(FileLoc, @"\", FileName);

        public static string FoglioStanza { get; } = "Stanze";

        public static int MaxRigheTextBox { get; } = 300;

        public enum Pagina
        {
            Stanze,
            Oggetti,
            Speciale
        }
    }
}
