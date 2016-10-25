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
        public static string FileName { get; } = @"Test.xlsx";
        public static string FileCompleto { get; } = String.Concat(FileLoc, @"\", FileName);

        public static string FoglioStanza { get; } = "Stanze";

        public static int MaxRigheTextBox { get; } = 300;

        public static int ERROR = 9666;

        public static int TICK_TIMER = 5000;        //Durata del Tick

        public static int PAGINA_STANZE = 1;
        public static int PAGINA_OGGETTI = 2;
        public static int PAGINA_TIPOOGGETTI = 3;
        public static int STANZE_COLONNE = 6;       //Numero di colonne nella pagina Stanze
        public static int OGGETTI_COLONNE = 6;      //Numero di colonne nella pagina Oggetti
        public static int OGGETTI_TIPOOGGETTI = 6;  //Numero di colonne nella pagina TipoOggetti

        public enum Pagina
        {
            Stanze,
            Oggetti,
            Speciale
        }
    }
}
