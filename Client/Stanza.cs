using Client;
using Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test01
{
    public class Stanza
    {
        public int? ID { get; set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }

        public string StringaOggetti
        {
            get { return string.Join(",", Oggetti); }
            set { Oggetti = value?.Split(','); }
        }
        public string[] Oggetti { get; set; }

        public string StringaPerson
        {
            get { return string.Join(",", Person); }
            set { Person = value?.Split(','); }
        }
        public string[] Person { get; set; }

        public string[] Special { get; set; }

        public List<Oggetto> OggettiStanza = new List<Oggetto>(); // = new List<Oggetto> { null };

        public Stanza(int? id = null, string nome = null, 
                      string descrizione = null, string oggetti = null, 
                      string person = null, string special = null)
        {
            ID = id;
            Nome = nome;
            Descrizione = descrizione;
            Oggetti = oggetti?.Split(',');
            Person = person?.Split(',');
            Special = special?.Split(',');
        }
        
        /*
         * SETTER dei PARAMETRI
         */
        public void SetPerson(string person = null)
        {
            Person = person.Split(',');
        }
        public void SetSpecial(string special = null)
        {
            Special = special.Split(',');
        }
        /*
         * FINE SETTERS
         */

        public void NuovaStanza(int contPagina, int id)
        {
            string strID = id.ToString();
            int contPaginaAtt = 1;
            var Test = new ExcelReader(Config.FileCompleto);
            //foreach(var paginaAtt in Workbook.Worksheets(@"C:\UTIL_EXTRA\Test.xlsx"))   //Per ogni Foglio
            foreach (var paginaAtt in Test.GetWorksheet())   //Per ogni Foglio
            {
                if (contPaginaAtt == Config.PAGINA_STANZE)                                        //Controllo se il Foglio attuale è quello cercato (contPagina)
                {
                    int RigaAtt = 1;
                    foreach(var Riga in paginaAtt.Rows)                                 //per ogni Riga
                    {
                        //int ColonnaAtt = 1;
                        string[] arrayRiga = new string[Riga.Cells.LongLength];
                        int elementi = 6;
                        //arrayRiga = null;
                        //Riga.Cells.CopyTo(arrayRiga, 0);
                        arrayRiga[0] = Riga.Cells[0].Text;
                        int.TryParse(strID, out elementi);
                        string prova = arrayRiga[0];
                        if (prova == strID)
                        {
                            int tempID;
                            int.TryParse(Riga.Cells[0].Text, out tempID);
                            ID = tempID;
                            Nome = Riga.Cells[1].Text;
                            Descrizione = Riga.Cells[2].Text;
                            StringaOggetti = Riga.Cells[3].Text;
                            int cc = Oggetti.Length;
                            foreach(var ogg in Oggetti)
                            {
                                int IDint;
                                int.TryParse(ogg, out IDint);
                                OggettiStanza.Add(new Oggetto(id: IDint));
                                //OggettiStanza.RemoveAt(el => el. = ID);
                            }

                            StringaPerson = Riga.Cells[4].Text;

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


        //public static Stanza ParseStanza(string Sheet, Stanza oggStanza, int id )
        //public static Stanza ParseStanza(string Sheet, string nome)
        //{
        //    Stanza oggStanza = new Stanza();
        //    //oggStanza = prova;
        //    string con = $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={Config.FileCompleto};Extended Properties='Excel 8.0;HDR=Yes;'";
        //    using (OleDbConnection connection = new OleDbConnection(con))
        //    {
        //        connection.Open();
        //        OleDbCommand command = new OleDbCommand($"select * from [{Sheet}$B2:B2]", connection);
        //        using (OleDbDataReader dr = command.ExecuteReader())
        //        {
        //            //string prova = dr.Read();
        //            while(dr.GetString(0) != nome)
        //            {
        //                dr.Read();
        //            }
        //            //string prova = dr.GetString();
        //            oggStanza.SetID(dr.GetInt32(0));
        //            oggStanza.SetNome(dr.GetString(1));
        //            oggStanza.SetDescrizione(dr.GetString(2));
        //            connection.Close();
        //            return oggStanza;
        //        }
        //    }
        //}


    }
}
