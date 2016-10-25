using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test01;

namespace Client
{

    public static class ControlExtensions
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool LockWindowUpdate(IntPtr hWndLock);

        public static void Suspend(this Control control)
        {
            LockWindowUpdate(control.Handle);
        }

        public static void Resume(this Control control)
        {
            LockWindowUpdate(IntPtr.Zero);
        }

    }

    static public class ElaboraTesto
    {
        public static int Recursione = 0;
        static public void Accorcia(RichTextBox box)
        {
            int lineCount = box.Lines.Length - Config.MaxRigheTextBox;
            int start_index = box.GetFirstCharIndexFromLine(lineCount);
            
            box.Select(0, start_index);
            box.Cut();
            
            box.SelectionStart = box.TextLength;
            box.ScrollToCaret();
        }

        /// <summary>
        /// Stampa un semplice testo
        /// </summary>
        /// <param name="box"></param>
        /// <param name="testo"></param>
        static public void StampaTesto(RichTextBox box, string testo)
        {
            VerificaLunghezza(box);

            box.AppendText(Environment.NewLine);
            box.SelectionFont = new Font("Courier New", 10, FontStyle.Regular);
            box.SelectionColor = Color.White;
            box.AppendText(testo);
        }

        /// <summary>
        /// Stampa nella 'box' il contenuto dell'oggetto 'stanza', formattandolo.
        /// </summary>
        /// <param name="box">RichTextBox in cui stampare</param>
        /// <param name="stanza">Oggetto Stanza da parsificare</param>
        static public void StampaStanza (RichTextBox box, Stanza stanza)
        {
            //Controllo testo all'interno della box
            VerificaLunghezza(box);

            //TITOLO Stanza
            box.AppendText(Environment.NewLine);
            box.SelectionFont = new Font("Courier New", 12, FontStyle.Bold);
            box.SelectionColor = Color.DarkRed;
            box.AppendText(stanza.Nome);
            //DESCRIZIONE Stanza
            box.AppendText(Environment.NewLine);
            box.SelectionFont = new Font("Courier New", 10, FontStyle.Regular);
            box.SelectionColor = Color.White;
            box.AppendText(stanza.Descrizione);
            //OGGETTI nella Stanza
            if (stanza.OggettiStanza.Count > 0)
            {
                box.AppendText(Environment.NewLine);
                box.SelectionFont = new Font("Courier New", 10, FontStyle.Regular);
                box.SelectionColor = Color.Blue;
                box.AppendText("Oggetti a terra:");
                foreach (var ogg in stanza.OggettiStanza)
                {
                    box.AppendText(Environment.NewLine);
                    box.SelectionFont = new Font("Courier New", 10, FontStyle.Regular);
                    box.SelectionColor = Color.Turquoise;
                    box.AppendText(ogg.Descrizione);
                }
            }
            box.ScrollToCaret();
        }

        static public void VerificaLunghezza(RichTextBox box)
        {
            if (box.Lines.Length > Config.MaxRigheTextBox)
            {
                box.Suspend();
                Accorcia(box);
                box.Resume();
            }
        }
    }
}
