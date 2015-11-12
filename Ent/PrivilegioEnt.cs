using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent
{
    public class PrivilegioEnt
    {
        #region Atributos
        private int id;
        private int id_usuario;
        private int id_opcion;
        private bool estado;
        #endregion
        #region Propiedades
        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public int ID_USUARIO
        {
            get { return this.id_usuario; }
            set { this.id_usuario = value; }
        }
        public int ID_OPCION
        {
            get { return this.id_opcion; }
            set { this.id_opcion = value; }
        }
        public bool ESTADO
        {
            get { return this.estado; }
            set { this.estado = value; }
        }
        #endregion
    }
}