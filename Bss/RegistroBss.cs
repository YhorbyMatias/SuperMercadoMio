using Dal;
using Ent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bss
{
    public class RegistroBss
    {
        #region Objetos
        RegistroDal objetoRegistro = new RegistroDal();
        #endregion
        #region Metodos
        public void insert(RegistroEnt registro)
        {
            objetoRegistro.insert(registro);
        }
        #endregion
    }
}