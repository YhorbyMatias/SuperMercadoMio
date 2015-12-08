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
    public class IngresoBss
    {
        #region Objetos
        private IngresoDal objetoIngreso = new IngresoDal();
        #endregion
        #region Metodos
        public int add(IngresoEnt ingreso)
        {
            return objetoIngreso.add(ingreso);
        }
        public void cancel(IngresoEnt ingreso)
        {
            objetoIngreso.cancel(ingreso);
        }
        public int existsId(IngresoEnt ingreso)
        {
            return objetoIngreso.existsId(ingreso);
        }
        public DataTable getById(IngresoEnt ingreso)
        {
            return objetoIngreso.getById(ingreso);
        }
        public int getMaxId(IngresoEnt ingreso)
        {
            return objetoIngreso.getMaxId(ingreso);
        }
        public int getMinId(IngresoEnt ingreso)
        {
            return objetoIngreso.getMinId(ingreso);
        }
        public int getNumeroDeRegistro(IngresoEnt ingreso)
        {
            return objetoIngreso.getNumeroDeRegistro(ingreso);
        }
        public DataTable search(ProveedorEnt proveedor, IngresoEnt ingreso, ProductoEnt producto)
        {
            return objetoIngreso.search(proveedor, ingreso, producto);
        }
        public void update(IngresoEnt ingreso)
        {
            objetoIngreso.update(ingreso);
        }
        #endregion
    }
}