using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Client
{
    public class Tick
    {
        private volatile bool _shouldStop;
        private int Contatore = 1;

        public Tick()
        {
            _shouldStop = false;
        }

        public void EseguiTick()
        {
            while (!_shouldStop)
            {
                frmClient form = new frmClient();
                form.lblContatoreTick.Text = Contatore.ToString();
            }
        }

        public void Ferma()
        {
            _shouldStop = true;
        }

    }
}
