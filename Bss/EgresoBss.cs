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
    public class EgresoBss
    {
        #region Objects
        EgresoDal objetoEgreso = new EgresoDal();
        public List<DetalleDeEgresoEnt> invoiceLines = new List<DetalleDeEgresoEnt>();
        #endregion
        #region Methods
        public int add(EgresoEnt egreso)
        {
            int id = objetoEgreso.add(egreso);
            DetalleDeEgresoBss objetoDetalleDeEgreso = new DetalleDeEgresoBss();
            foreach (DetalleDeEgresoEnt invoiceLine in invoiceLines)
            {
                invoiceLine.ID_EGRESO = id;
                objetoDetalleDeEgreso.add(invoiceLine);
            }
            invoiceLines.Clear();
            return id;
        }
        public void cancel(EgresoEnt egreso)
        {
            objetoEgreso.cancel(egreso);
        }
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
        public int getNumber()
        {
            return objetoEgreso.getNumber();
        }
        public decimal getCouponsTotalAmount(EgresoEnt egreso)
        {
            return objetoEgreso.getCouponsTotalAmount(egreso);
        }
        public decimal getExtraTotalAmount(EgresoEnt egreso)
        {
            return objetoEgreso.getExtraTotalAmount(egreso);
        }
        public decimal getSalesTotalAmount(EgresoEnt egreso)
        {
            return objetoEgreso.getSalesTotalAmount(egreso);
        }
        public bool isClosed(EgresoEnt egreso)
        {
            return objetoEgreso.isClosed(egreso);
        }
        public void update(EgresoEnt egreso)
        {
            objetoEgreso.update(egreso);
        }
        public void updateFacturado(EgresoEnt egreso)
        {
            objetoEgreso.updateFacturado(egreso);
        }
        public void updateFacturadoById(EgresoEnt egreso)
        {
            objetoEgreso.updateFacturadoById(egreso);
        }
        #endregion
    }
}