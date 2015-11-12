using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent
{
    public class ProveedorEnt
    {
        #region Atributos
        private int id;
        private string nit;
        private string nombre;
        private string persona_de_contacto;
        private string direccion;
        private string telefono;
        private string celular;
        private string numero_de_cuenta;
        private bool estado;
        #endregion
        #region Propiedades
        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string NIT
        {
            get { return this.nit; }
            set { this.nit = value; }
        }
        public string NOMBRE
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public string PERSONA_DE_CONTACTO
        {
            get { return this.persona_de_contacto; }
            set { this.persona_de_contacto = value; }
        }
        public string DIRECCION
        {
            get { return this.direccion; }
            set { this.direccion = value; }
        }
        public string TELEFONO
        {
            get { return this.telefono; }
            set { this.telefono = value; }
        }
        public string CELULAR
        {
            get { return this.celular; }
            set { this.celular = value; }
        }
        public string NUMERO_DE_CUENTA
        {
            get { return this.numero_de_cuenta; }
            set { this.numero_de_cuenta = value; }
        }
        public bool ESTADO
        {
            get { return this.estado; }
            set { this.estado = value; }
        }
        #endregion
    }
}