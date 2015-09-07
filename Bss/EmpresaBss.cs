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
        EmpresaDal empresa = new EmpresaDal();
        #endregion
        #region Metodos
        public int exists()
        {
            return empresa.exists();
        }
        public int insert(EmpresaEnt empresaX)
        {
            return empresa.insert(empresaX);
        }
        public void update(EmpresaEnt empresaX)
        {
            empresa.update(empresaX);
        }
        public DataTable search()
        {
            return empresa.search();
        }
        public DataTable select()
        {
            return empresa.select();
        }
        #endregion
    }
}