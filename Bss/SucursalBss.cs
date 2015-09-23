﻿using Dal;
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
        SucursalDal objetoSucursal = new SucursalDal();
        #endregion
        #region Metodos
        public int exists()
        {
            return objetoSucursal.exists();
        }
        public int insert(SucursalEnt sucursal)
        {
            return objetoSucursal.insert(sucursal);
        }
        public void update(SucursalEnt sucursal)
        {
            objetoSucursal.update(sucursal);
        }
        public DataTable search()
        {
            return objetoSucursal.search();
        }
        public DataTable select()
        {
            return objetoSucursal.select();
        }
        #endregion
    }
}