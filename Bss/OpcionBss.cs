using Dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bss
{
    public class OpcionBss
    {
        #region Objetos
        private OpcionDal objetoOpcion = new OpcionDal();
        #endregion
        #region Metodos
        public DataTable search()
        {
            return objetoOpcion.search();
        }
        #endregion
    }
}