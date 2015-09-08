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
    public class GrupoBss
    {
        #region Objetos
        GrupoDal grupo = new GrupoDal();
        #endregion
        #region Metodos
        public int authenticate(GrupoEnt grupoX)
        {
            return grupo.authenticate(grupoX);
        }
        public void delete(GrupoEnt grupoX)
        {
            grupo.delete(grupoX);
        }
        public int insert(GrupoEnt grupoX)
        {
            return grupo.insert(grupoX);
        }
        public DataTable search(GrupoEnt grupoX)
        {
            return grupo.search(grupoX);
        }
        public DataTable searchAll()
        {
            return grupo.searchAll();
        }
        public DataTable searchRemovable()
        {
            return grupo.searchRemovable();
        }
        public DataTable selectAll()
        {
            return grupo.selectAll();
        }
        public void update(GrupoEnt grupoX)
        {
            grupo.update(grupoX);
        }
        #endregion
    }
}