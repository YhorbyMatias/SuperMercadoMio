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
        private PrivilegioDal privilegio = new PrivilegioDal();
        #endregion
        #region Metodos
        public void delete(PrivilegioEnt privilegioX)
        {
            privilegio.delete(privilegioX);
        }
        public int exists(OpcionEnt opcionX, PrivilegioEnt privilegioX)
        {
            return privilegio.exists(opcionX, privilegioX);
        }
        public DataTable find(PrivilegioEnt privilegioX)
        {
            return privilegio.find(privilegioX);
        }
        public int insert(PrivilegioEnt privilegioX)
        {
            return privilegio.insert(privilegioX);
        }
        public DataTable search(PrivilegioEnt privilegioX)
        {
            return privilegio.search(privilegioX);
        }
        public DataTable select(PrivilegioEnt privilegioX)
        {
            return privilegio.select(privilegioX);
        }
        #endregion
    }
}