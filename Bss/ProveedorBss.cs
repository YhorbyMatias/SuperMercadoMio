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
        ProveedorDal objetoProveedor = new ProveedorDal();
        #endregion
        #region Metodos
        public int authenticateNit(ProveedorEnt proveedor)
        {
            return objetoProveedor.authenticateNit(proveedor);
        }
        public void delete(ProveedorEnt proveedor)
        {
            objetoProveedor.delete(proveedor);
        }
        public int insert(ProveedorEnt proveedor)
        {
            return objetoProveedor.insert(proveedor);
        }
        public DataTable search(ProveedorEnt proveedor)
        {
            return objetoProveedor.search(proveedor);
        }
        public DataTable searchAll()
        {
            return objetoProveedor.searchAll();
        }
        public DataTable searchRemovable()
        {
            return objetoProveedor.searchRemovable();
        }
        public DataTable select(ProveedorEnt proveedor)
        {
            return objetoProveedor.select(proveedor);
        }
        public DataTable selectAll()
        {
            return objetoProveedor.selectAll();
        }
        public void update(ProveedorEnt proveedor)
        {
            objetoProveedor.update(proveedor);
        }
        #endregion
    }
}