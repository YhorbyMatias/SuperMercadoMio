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
    public class EmpresaBss
    {
        #region Objetos
        EmpresaDal objetoEmpresa = new EmpresaDal();
        #endregion
        #region Metodos
        public DataTable search()
        {
            return objetoEmpresa.search();
        }
        public DataTable select()
        {
            return objetoEmpresa.select();
        }
        public void update(EmpresaEnt empresa)
        {
            objetoEmpresa.update(empresa);
        }
        #endregion
    }
}