using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent
{
    public class GrupoEnt
    {
        #region Atributos
        private int id;
        private string nombre;
        private bool estado;
        #endregion
        #region Propiedades
        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
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