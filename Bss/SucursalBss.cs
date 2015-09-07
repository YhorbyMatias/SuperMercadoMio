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
    public class SucursalBss
    {
        #region Objetos
        SucursalDal sucursal = new SucursalDal();
        #endregion
        #region Metodos
        public int exists()
        {
            return sucursal.exists();
        }
        public int insert(SucursalEnt sucursalX)
        {
            return sucursal.insert(sucursalX);
        }
        public void update(SucursalEnt sucursalX)
        {
            sucursal.update(sucursalX);
        }
        public DataTable search()
        {
            return sucursal.search();
        }
        public DataTable select()
        {
            return sucursal.select();
        }
        #endregion
    }
}