using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Client
{
    public class MultiThreading
    {
        public void StartTick()
        {
            Tick tick = new Tick();
            Thread TTick = new Thread(c => tick.EseguiTick());
            TTick.Start();
            while (!TTick.IsAlive);
            tick.Ferma();
            TTick.Join();
        }
    }
}
