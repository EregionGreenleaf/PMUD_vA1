using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test01;
//using Test01;

namespace Client
{
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Stanza provaStanza = new Stanza();
            provaStanza.NuovaStanza(1);

            ElaboraTesto.Recursione += 1;
            ElaboraTesto.StampaTesto(rtbBlocco, Convert.ToString(ElaboraTesto.Recursione));

            ElaboraTesto.StampaStanza(rtbBlocco, provaStanza);
        }

        private void frmClient_Load(object sender, EventArgs e)
        {

        }

        //static void SetLabelContatore(string valore)
        //{
        //    lblContatoreTick.Text = valore;
        //}
        //public string GetLabelContatore()
        //{
        //    return this.lblContatoreTick.Text;
        //}
    }
}
