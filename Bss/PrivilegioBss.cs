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
    public class PrivilegioBss
    {
        #region Objetos
        private PrivilegioDal objetoPrivilegio = new PrivilegioDal();
        #endregion
        #region Metodos
        public void delete(PrivilegioEnt privilegio)
        {
            objetoPrivilegio.delete(privilegio);
        }
        public int exists(OpcionEnt opcion, PrivilegioEnt privilegio)
        {
            return objetoPrivilegio.exists(opcion, privilegio);
        }
        public DataTable find(PrivilegioEnt privilegio)
        {
            return objetoPrivilegio.find(privilegio);
        }
        public int insert(PrivilegioEnt privilegio)
        {
            return objetoPrivilegio.insert(privilegio);
        }
        public DataTable search(PrivilegioEnt privilegio)
        {
            return objetoPrivilegio.search(privilegio);
        }
        public DataTable select(PrivilegioEnt privilegio)
        {
            return objetoPrivilegio.select(privilegio);
        }
        #endregion
    }
}