using Dal;
using Ent;
using System;
using System.Collections.Generic;
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
        public int insert(DetalleDeIngresoEnt detalleDeIngreso)
        {
            return objetoDetalleDeIngreso.insert(detalleDeIngreso);
        }
        #endregion
    }
}