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
    public class ProductoBss
    {
        #region Objetos
        ProductoDal objetoProducto = new ProductoDal();
        #endregion
        #region Metodos
        public int authenticate(ProductoEnt producto)
        {
            return objetoProducto.authenticate(producto);
        }
        public int authenticateAlias(ProductoEnt producto)
        {
            return objetoProducto.authenticateAlias(producto);
        }
        public int authenticateCodigoDeBarras(ProductoEnt producto)
        {
            return objetoProducto.authenticateCodigoDeBarras(producto);
        }
        public DataTable findAll()
        {
            return objetoProducto.findAll();
        }
        public int insert(ProductoEnt producto)
        {
            return objetoProducto.insert(producto);
        }
        public int getNumber(ProductoEnt producto)
        {
            return objetoProducto.getNumber(producto);
        }
        public DataTable search(ProductoEnt producto)
        {
            return objetoProducto.search(producto);
        }
        public DataTable searchAll()
        {
            return objetoProducto.searchAll();
        }
        public DataTable searchMarcas()
        {
            return objetoProducto.searchMarcas();
        }
        public DataTable select(ProductoEnt producto)
        {
            return objetoProducto.select(producto);
        }
        public DataTable selectAll()
        {
            return objetoProducto.selectAll();
        }
        public void update(ProductoEnt producto)
        {
            objetoProducto.update(producto);
        }
        public void updatePrecios(ProductoEnt producto)
        {
            objetoProducto.updatePrecios(producto);
        }
        #endregion
    }
}