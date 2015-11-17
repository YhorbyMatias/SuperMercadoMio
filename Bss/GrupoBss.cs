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
        GrupoDal objetoGrupo = new GrupoDal();
        #endregion
        #region Metodos
        public int add(GrupoEnt grupo)
        {
            return objetoGrupo.add(grupo);
        }
        public int authenticate(GrupoEnt grupo)
        {
            return objetoGrupo.authenticate(grupo);
        }
        public void delete(GrupoEnt grupo)
        {
            objetoGrupo.delete(grupo);
        }
        public DataTable search(GrupoEnt grupo)
        {
            return objetoGrupo.search(grupo);
        }
        public DataTable searchAll()
        {
            return objetoGrupo.searchAll();
        }
        public DataTable searchRemovable()
        {
            return objetoGrupo.searchRemovable();
        }
        public DataTable selectAll()
        {
            return objetoGrupo.selectAll();
        }
        public void update(GrupoEnt grupo)
        {
            objetoGrupo.update(grupo);
        }
        #endregion
    }
}