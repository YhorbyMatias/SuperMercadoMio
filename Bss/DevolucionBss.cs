using Dal;
using Ent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bss
{
    public class DevolucionBss
    {
        #region Objects
        DevolucionDal objetoDevolucion = new DevolucionDal();
        #endregion
        #region Methods
        public void close(DevolucionEnt devolucion)
        {
            objetoDevolucion.close(devolucion);
        }
        public decimal getRefundsTotalAmount(DevolucionEnt devolucion)
        {
            return objetoDevolucion.getRefundsTotalAmount(devolucion);
        }
        #endregion
    }
}