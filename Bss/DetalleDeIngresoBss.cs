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
        private DetalleDeIngresoDal detalleDeIngreso = new DetalleDeIngresoDal();
        #endregion
        #region Metodos
        public int insert(DetalleDeIngresoEnt detalleDeIngresoX)
        {
            return detalleDeIngreso.insert(detalleDeIngresoX);
        }
        #endregion
    }
}