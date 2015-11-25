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
    public class DetalleDeEgresoBss
    {
        #region Objects
        DetalleDeEgresoDal objetoDetalleDeEgreso = new DetalleDeEgresoDal();
        #endregion
        #region Methods
        public int add(DetalleDeEgresoEnt detalleDeEgreso)
        {
            return objetoDetalleDeEgreso.add(detalleDeEgreso);
        }
        public DataTable getMinorSalesDetail(EgresoEnt egreso)
        {
            return objetoDetalleDeEgreso.getMinorSalesDetail(egreso);
        }
        #endregion
    }
}