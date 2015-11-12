using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent
{
    public class ClienteEnt
    {
        #region Atributos
        private int id;
        private string ci_o_nit;
        private string nombre;
        private bool estado;
        #endregion
        #region Propiedades
        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string CI_O_NIT
        {
            get { return this.ci_o_nit; }
            set { this.ci_o_nit = value; }
        }
        public string NOMBRE
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public bool ESTADO
        {
            get { return this.estado; }
            set { this.estado = value; }
        }
        #endregion
    }
}