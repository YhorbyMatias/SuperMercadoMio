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
        private int id_grupo;
        private string nombre;
        private bool estado;
        #endregion
        #region Propiedades
        public int ID_GRUPO
        {
            get { return this.id_grupo; }
            set { this.id_grupo = value; }
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