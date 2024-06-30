using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    internal class EntityOgretmen
    {
        private int ogrid;

        public int OGRTID
        {
            get { return ogrid; }
            set { ogrid = value; }
        }

        private int ogrtbrans;

        public int OGRTBRANS
        {
            get { return ogrtbrans; }
            set { ogrtbrans = value; }
        }

        private string ogrtad;

        public string OGRTAD
        {
            get { return ogrtad; }
            set { ogrtad = value; }
        }

    }
}
