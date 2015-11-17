using Dal;
using Ent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bss
{
    public class CierreDeCajaBss
    {
        #region Objects
        CierreDeCajaDal objetoCierreDeCaja = new CierreDeCajaDal();
        #endregion
        #region Methods
        public int add(CierreDeCajaEnt cierreDeCaja)
        {
            return objetoCierreDeCaja.add(cierreDeCaja);
        }
        #endregion
    }
}