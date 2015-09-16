using Dal;
using Ent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bss
{
    public class IngresoBss
    {
        #region Objetos
        private IngresoDal ingreso = new IngresoDal();
        #endregion
        #region Metodos
        public int insert(IngresoEnt ingresoX)
        {
            return ingreso.insert(ingresoX);
        }
        #endregion
    }
}