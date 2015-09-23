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
        private IngresoDal objetoIngreso = new IngresoDal();
        #endregion
        #region Metodos
        public int getNumeroDeRegistro()
        {
            return objetoIngreso.getNumeroDeRegistro();
        }
        public int insert(IngresoEnt ingreso)
        {
            return objetoIngreso.insert(ingreso);
        }
        #endregion
    }
}