using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent
{
    public class CajaEnt
    {
        #region Atributos
        private int id;
        private string nombre_de_equipo;
        private string numero;
        private string estado;
        #endregion
        #region Propiedades
        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string NOMBRE_DE_EQUIPO
        {
            get { return this.nombre_de_equipo; }
            set { this.nombre_de_equipo = value; }
        }
        public string NUMERO
        {
            get { return this.numero; }
            set { this.numero = value; }
        }
        public string ESTADO
        {
            get { return this.estado; }
            set { this.estado = value; }
        }
        #endregion
    }
}