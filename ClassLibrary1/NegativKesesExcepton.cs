using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class NegativKesesExcepton : Exception
    {
        public NegativKesesExcepton(int keses) : base("Nincs késés" + keses)
        {
            //Nincs késés
        }
    }
}
