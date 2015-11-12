using Dal;
using Ent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bss
{
    public class CajaBss
    {
        #region Objects
        CajaDal objetoCaja = new CajaDal();
        #endregion
        #region Methods
        public int add(CajaEnt caja)
        {
            return objetoCaja.add(caja);
        }
        public int authenticateNumber(CajaEnt caja)
        {
            return objetoCaja.authenticateNumber(caja);
        }
        #endregion
    }
}