using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Client
{
    class Tick
    {
        private volatile bool _shouldStop;
        private int Contatore = 1;
        public void EseguiTick()
        {
            frmClient.SetLabelContatore(Contatore.ToString());
        }

    }
}
