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
    public class DetalleDeFacturaBss
    {
        #region Objects
        DetalleDeFacturaDal objetoDetalleDeFactura = new DetalleDeFacturaDal();
        #endregion
        #region Methods
        public int add(DetalleDeFacturaEnt detalleDeFactura)
        {
            return objetoDetalleDeFactura.add(detalleDeFactura);
        }
        public DataTable getById(DetalleDeFacturaEnt detalleDeFactura)
        {
            return objetoDetalleDeFactura.getById(detalleDeFactura);
        }
        public DataTable obtainById(DetalleDeFacturaEnt detalleDeFactura)
        {
            return objetoDetalleDeFactura.obtainById(detalleDeFactura);
        }
        #endregion
    }
}