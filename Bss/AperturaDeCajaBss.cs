using Dal;
using Ent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bss
{
    public class AperturaDeCajaBss
    {
        #region Objects
        AperturaDeCajaDal objetoAperturaDeCaja = new AperturaDeCajaDal();
        #endregion
        #region Methods
        public int add(AperturaDeCajaEnt aperturaDeCaja)
        {
            return objetoAperturaDeCaja.add(aperturaDeCaja);
        }
        #endregion
    }
}