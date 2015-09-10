using Dal;
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
        public DataTable searchMarcas()
        {
            return producto.searchMarcas();
        }
        #endregion
    }
}