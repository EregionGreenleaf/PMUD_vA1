using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test01
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Client_Load(object sender, EventArgs e)
        {
            Stanza provaStanza = new Stanza();
            //provaStanza = Stanza.ParseStanza(Config.FoglioStanza, "Salone");
            provaStanza.NuovaStanza(1, 1);
            richTextBox1.AppendText(provaStanza.Nome + "\n" + provaStanza.Descrizione);
        }
    }
}
