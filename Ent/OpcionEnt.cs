using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent
{
    public class OpcionEnt
    {
        #region Atributos
        private int id_opcion;
        private string nombre;
        private bool estado;
        #endregion
        #region Propiedades
        public int ID_OPCION
        {
            get { return this.id_opcion; }
            set { this.id_opcion = value; }
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