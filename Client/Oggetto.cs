using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test01;

namespace Client
{
    public class Oggetto
    {
        public int? ID { get; set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public string[] Tipo { get; set; }
        public int? Valore { get; set; }
        public int? Peso { get; set; }

        public Oggetto(int? id = null, string nome = null,
                      string descrizione = null, string tipo = null, int? valore = null, int? peso = null)
        {
            ID = id;
            /*Nome = nome;
            Descrizione = descrizione;
            Tipo = tipo?.Split(',');
            Valore = valore;
            Peso = peso*/
            this.RiempiOggetto();

        }

        public void SetValore ( int valore )
        {
            Valore = valore;
        }

        public void RiempiOggetto()
        {
            string strID = ID.ToString();
            int contPaginaAtt = 1;
            var Test = new ExcelReader(Config.FileCompleto);
            //foreach(var paginaAtt in Workbook.Worksheets(@"C:\UTIL_EXTRA\Test.xlsx"))   //Per ogni Foglio
            foreach (var paginaAtt in Test.GetWorksheet())   //Per ogni Foglio
            {
                if (contPaginaAtt == Config.PAGINA_OGGETTI)                                        //Controllo se il Foglio attuale è quello cercato (contPagina)
                {
                    int RigaAtt = 1;
                    foreach (var Riga in paginaAtt.Rows)                                 //per ogni Riga
                    {
                        //int ColonnaAtt = 1;
                        string[] arrayRiga = new string[Riga.Cells.LongLength];
                        int elementi = 6;
                        //arrayRiga = null;
                        //Riga.Cells.CopyTo(arrayRiga, 0);
                        arrayRiga[0] = Riga.Cells[0].Text;
                        int.TryParse(strID, out elementi);
                        string IDRiga = arrayRiga[0];
                        if (IDRiga == strID)
                        {
                            int tempID = Config.ERROR;
                            int.TryParse(Riga.Cells[0].Text, out tempID);
                            ID = tempID != Config.ERROR? tempID : Config.ERROR;
                            Nome = Riga.Cells[1].Text;
                            Descrizione = Riga.Cells[2].Text;
                            Tipo = Riga.Cells[3].Text.Split(',');
                            int valore = 0;
                            int.TryParse(Riga.Cells[4].Text, out valore);
                            Valore = valore;

                            //foreach (var ogg in Tipo)
                            //{
                            //    OggettiStanza.Add(new Oggetto(id: ogg));
                            //}

                            //StringaPerson = Riga.Cells[4].Text;

                        }

                        //foreach(var Cella in Riga.Cells)                                //Per ogni Colonna
                        //{
                        //    ColonnaAtt += 1;
                        //}
                        RigaAtt += 1;
                    }
                }
                contPaginaAtt += 1;
            }
        }

        
    }
}
