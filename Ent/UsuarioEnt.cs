using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent
{
    public class UsuarioEnt
    {
        #region Atributos
        private int id_usuario;
        private string ci;
        private string nombres;
        private string apellido_paterno;
        private string apellido_materno;
        private string telefono;
        private string nombre_de_usuario;
        private string clave;
        private bool estado;
        #endregion
        #region Propiedades
        public int ID_USUARIO
        {
            get { return this.id_usuario; }
            set { this.id_usuario = value; }
        }
        public string CI
        {
            get { return this.ci; }
            set { this.ci = value; }
        }
        public string NOMBRES
        {
            get { return this.nombres; }
            set { this.nombres = value; }
        }
        public string APELLIDO_PATERNO
        {
            get { return this.apellido_paterno; }
            set { this.apellido_paterno = value; }
        }
        public string APELLIDO_MATERNO
        {
            get { return this.apellido_materno; }
            set { this.apellido_materno = value; }
        }
        public string TELEFONO
        {
            get { return this.telefono; }
            set { this.telefono = value; }
        }
        public string NOMBRE_DE_USUARIO
        {
            get { return this.nombre_de_usuario; }
            set { this.nombre_de_usuario = value; }
        }
        public string CLAVE
        {
            get { return this.clave; }
            set { this.clave = value; }
        }
        public bool ESTADO
        {
            get { return this.estado; }
            set { this.estado = value; }
        }
        #endregion
    }
}