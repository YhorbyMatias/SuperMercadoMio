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
    public class ClienteBss
    {
        #region Objects
        ClienteDal objetoCliente = new ClienteDal();
        #endregion
        #region Methods
        public int add(ClienteEnt cliente)
        {
            return objetoCliente.add(cliente);
        }
        public int authenticateCiONit(ClienteEnt cliente)
        {
            return objetoCliente.authenticateCiONit(cliente);
        }
        public int authenticateName(ClienteEnt cliente)
        {
            return objetoCliente.authenticateName(cliente);
        }
        public void delete(ClienteEnt cliente)
        {
            objetoCliente.delete(cliente);
        }
        public DataTable getAll()
        {
            return objetoCliente.getAll();
        }
        public DataTable getByCiONit(ClienteEnt cliente)
        {
            return objetoCliente.getByCiONit(cliente);
        }
        public DataTable getById(ClienteEnt cliente)
        {
            return objetoCliente.getById(cliente);
        }
        public DataTable getRemovable()
        {
            return objetoCliente.getRemovable();
        }
        public void update(ClienteEnt cliente)
        {
            objetoCliente.update(cliente);
        }
        #endregion
    }
}