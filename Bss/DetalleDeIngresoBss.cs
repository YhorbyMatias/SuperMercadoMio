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
    public class DetalleDeIngresoBss
    {
        #region Objetos
        private DetalleDeIngresoDal objetoDetalleDeIngreso = new DetalleDeIngresoDal();
        #endregion
        #region Metodos
        public int add(DetalleDeIngresoEnt detalleDeIngreso)
        {
            return objetoDetalleDeIngreso.add(detalleDeIngreso);
        }
        public void cancel(DetalleDeIngresoEnt detalleDeIngreso)
        {
            objetoDetalleDeIngreso.cancel(detalleDeIngreso);
        }
        public void delete(DetalleDeIngresoEnt detalleDeIngreso)
        {
            objetoDetalleDeIngreso.delete(detalleDeIngreso);
        }
        public DataTable getByIngresoId(DetalleDeIngresoEnt detalleDeIngreso)
        {
            return objetoDetalleDeIngreso.getByIngresoId(detalleDeIngreso);
        }
        public void update(DetalleDeIngresoEnt detalleDeIngreso)
        {
            objetoDetalleDeIngreso.update(detalleDeIngreso);
        }
        #endregion
    }
}