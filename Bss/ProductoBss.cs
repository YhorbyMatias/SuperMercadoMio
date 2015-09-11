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
        ProductoDal producto = new ProductoDal();
        #endregion
        #region Metodos
        public int authenticate(ProductoEnt productoX)
        {
            return producto.authenticate(productoX);
        }
        public int authenticateAlias(ProductoEnt productoX)
        {
            return producto.authenticateAlias(productoX);
        }
        public int authenticateCodigoDeBarras(ProductoEnt productoX)
        {
            return producto.authenticateCodigoDeBarras(productoX);
        }
        public int insert(ProductoEnt productoX)
        {
            return producto.insert(productoX);
        }
        public int getNumber(ProductoEnt productoX)
        {
            return producto.getNumber(productoX);
        }
        public DataTable searchMarcas()
        {
            return producto.searchMarcas();
        }
        #endregion
    }
}