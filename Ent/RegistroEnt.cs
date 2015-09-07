using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent
{
    public class RegistroEnt
    {
        #region Atributos
        private int id_registro;
        private string usuario;
        private string equipo;
        private string fecha;
        private string hora;
        private string tabla;
        private int id_tabla;
        private string tipo;
        #endregion
        #region Propiedades
        public int ID_REGISTRO
        {
            get { return this.id_registro; }
            set { this.id_registro = value; }
        }
        public string USUARIO
        {
            get { return this.usuario; }
            set { this.usuario = value; }
        }
        public string EQUIPO
        {
            get { return this.equipo; }
            set { this.equipo = value; }
        }
        public string FECHA
        {
            get { return this.fecha; }
            set { this.fecha = value; }
        }
        public string HORA
        {
            get { return this.hora; }
            set { this.hora = value; }
        }
        public string TABLA
        {
            get { return this.tabla; }
            set { this.tabla = value; }
        }
        public int ID_TABLA
        {
            get { return this.id_tabla; }
            set { this.id_tabla = value; }
        }
        public string TIPO
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }
        #endregion
    }
}