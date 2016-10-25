using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test01
{
    class Program
    {
        public static void getValues(int Charlie, out int x, out int y, out int z)
        {
            Console.WriteLine("Enter the first value: ");
            x = Convert.ToInt32(Console.ReadLine())*Charlie;
            Console.WriteLine("Enter the second value: ");
            y = Convert.ToInt32(Console.ReadLine())*Charlie;
            Console.WriteLine("Enter the third value: ");
            z = Convert.ToInt32(Console.ReadLine())*Charlie;

            var stanza = new Stanza(id: 1, 
                                    nome: string.Empty, 
                                    descrizione: string.Empty, 
                                    oggetti: string.Empty, 
                                    person: string.Empty, 
                                    special: string.Empty);
            var altraStanza = new Stanza
            {
                ID = 1,
                Nome = string.Empty,
                Descrizione = string.Empty,
                Oggetti = null,

            };
        }

/*       
        static void Main()
        {
            //console.writeline("hello world!");
            //int a, b, c, prova;
            ////program gv = new program();
            ////gv.getvalues(2, out a,out b, out c);
            ////program.getvalues(convert.toint32(console.readline()), out a, out b, out c);
            //program.getvalues(int.tryparse(console.readline(), out prova) ? convert.toint32(prova) : 2, out a, out b, out c);
            //console.writeline("valore di a: {0} \nvalore di b: {1}\nvalore di c: {2}", a, b, c);
            //console.readline();

            string a, b, c;
            int d;

            DatiMaster dati = new DatiMaster();
            Console.WriteLine("Inserisci il nome:");
            dati.setNome(Console.ReadLine());
            Console.WriteLine("Inserisci il cognome:");
            dati.setCognome(Console.ReadLine());
            Console.WriteLine("Inserisci l'IBAN:");
            dati.setIBAN(Console.ReadLine());
            dati.getData(out a, out b, out c, out d);
            Console.WriteLine($"\nQuesti sono i dati immessi: \nNome: {a}\nCognome: {b}\nIBAN: {c}\nID: {d}");

            Console.ReadLine(); 
        }
*/
    }

    class DatiMaster
    {
        private string Nome;
        private string Cognome;
        private DatiSlave vDati = new DatiSlave("", 0);
        public DatiMaster()
        {
            Nome = "";
            Cognome = "";
            vDati.setIBAN("");
            vDati.setID(0);

        }

        public DatiMaster(string vN, string vC, string vIBAN, int vID)
        {
            Nome = vN;
            Cognome = vC;
            vDati.setIBAN(vIBAN);
            vDati.setID(vID);
        }

        public void setNome(string nome)
        {
            Nome = nome;
            calcolaID();
        }

        public void setCognome(string cognome)
        {
            Cognome = cognome;
            calcolaID();
        }

        public void setIBAN(string valIBAN)
        {
            vDati.setIBAN(valIBAN);
            calcolaID();
        }

        public void setID (/*int valID*/)
        {
            calcolaID();
            //vDati.setID(valID);
        }

        public void getData(out string nome, out string cognome, out string IBAN, out int ID)
        {
            nome = Nome;
            cognome = Cognome;
            IBAN = vDati.getIBAN();
            ID = vDati.getID();
        }

        private void calcolaID()
        {
            Random cc = new Random();
            int cas = cc.Next(10);
            int prooo = cc.Next(10);
            int cont;
            string temp = vDati.getIBAN();
            //int.TryParse(cas / prooo, out cont);
            vDati.setID((15485863 ^ Nome.Length ^ Cognome.Length ^ temp.Length) * prooo );
        }
    }


    class DatiSlave
    {
        private string IBAN;
        private int ID;

        public DatiSlave()
        {
            IBAN = "";
            ID = 0;
        }

        public DatiSlave(int valore)
        {
            IBAN = "";
            ID = valore;
        }

        public DatiSlave(string Valore)
        {
            IBAN = Valore;
            ID = 0;
        }

        public DatiSlave(string Valore, int valore)
        {
            IBAN = Valore;
            ID = valore;
        }
        public void setIBAN(string codice)
        {
            IBAN = codice;
        }

        public void setID (int codice)
        {
            ID = codice;
        }

        public string getIBAN()
        {
            return IBAN;
        }

        public int getID()
        {
            return ID;
        }
    }
}
