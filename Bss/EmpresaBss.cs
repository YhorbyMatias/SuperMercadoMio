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
        public int exists()
        {
            return objetoEmpresa.exists();
        }
        public int insert(EmpresaEnt empresa)
        {
            return objetoEmpresa.insert(empresa);
        }
        public void update(EmpresaEnt empresa)
        {
            objetoEmpresa.update(empresa);
        }
        public DataTable search()
        {
            return objetoEmpresa.search();
        }
        public DataTable select()
        {
            return objetoEmpresa.select();
        }
        #endregion
    }
}