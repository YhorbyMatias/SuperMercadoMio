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
    public class ProveedorBss
    {
        #region Objetos
        ProveedorDal proveedor = new ProveedorDal();
        #endregion
        #region Metodos
        public int authenticateNit(ProveedorEnt proveedorX)
        {
            return proveedor.authenticateNit(proveedorX);
        }
        public void delete(ProveedorEnt proveedorX)
        {
            proveedor.delete(proveedorX);
        }
        public int insert(ProveedorEnt proveedorX)
        {
            return proveedor.insert(proveedorX);
        }
        public DataTable search(ProveedorEnt proveedorX)
        {
            return proveedor.search(proveedorX);
        }
        public DataTable searchAll()
        {
            return proveedor.searchAll();
        }
        public DataTable searchRemovable()
        {
            return proveedor.searchRemovable();
        }
        public DataTable select(ProveedorEnt proveedorX)
        {
            return proveedor.select(proveedorX);
        }
        public DataTable selectAll()
        {
            return proveedor.selectAll();
        }
        public void update(ProveedorEnt proveedorX)
        {
            proveedor.update(proveedorX);
        }
        #endregion
    }
}