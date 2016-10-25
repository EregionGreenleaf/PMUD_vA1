using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test01
{
    class TestMain
    {
        public void Main()
        {
            Stanza mStanza = new Stanza();
            string foglio = "Stanze";

            mStanza = Stanza.ParseStanza(Config.FoglioStanza, 1);
        }
    }
}
