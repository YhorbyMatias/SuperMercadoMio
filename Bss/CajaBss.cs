using Dal;
using Ent;
using System;
using System.Collections.Generic;
using System.Data;
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
        public void delete(CajaEnt caja)
        {
            objetoCaja.delete(caja);
        }
        public int exists(CajaEnt caja)
        {
            return objetoCaja.exists(caja);
        }
        public DataTable getAll()
        {
            return objetoCaja.getAll();
        }
        public DataTable getAllRemovable()
        {
            return objetoCaja.getAllRemovable();
        }
        public DataTable getById(CajaEnt caja)
        {
            return objetoCaja.getById(caja);
        }
        public int getId(CajaEnt caja)
        {
            return objetoCaja.getId(caja);
        }
        public int getNumber(CajaEnt caja)
        {
            return objetoCaja.getNumber(caja);
        }
        public void update(CajaEnt caja)
        {
            objetoCaja.update(caja);
        }
        #endregion
    }
}