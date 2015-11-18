﻿using Dal;
using Ent;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bss
{
    public class EgresoBss
    {
        #region Objects
        EgresoDal objetoEgreso = new EgresoDal();
        #endregion
        #region Methods
        public void close(EgresoEnt egreso)
        {
            objetoEgreso.close(egreso);
        }
        public int existsMinorSales(EgresoEnt egreso)
        {
            return objetoEgreso.existsMinorSales(egreso);
        }
        public DataTable getMinorSales(EgresoEnt egreso)
        {
            return objetoEgreso.getMinorSales(egreso);
        }
        public decimal getSalesTotalAmount(EgresoEnt egreso)
        {
            return objetoEgreso.getSalesTotalAmount(egreso);
        }
        #endregion
    }
}