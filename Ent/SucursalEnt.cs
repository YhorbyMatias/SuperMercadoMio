using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent
{
    public class SucursalEnt
    {
        #region Atributos
        private int id;
        private int id_empresa;
        private string numero;
        private string direccion;
        private string telefono;
        private string municipio;
        private bool estado;
        #endregion
        #region Propiedades
        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public int ID_EMPRESA
        {
            get { return this.id_empresa; }
            set { this.id_empresa = value; }
        }
        public string NUMERO
        {
            get { return this.numero; }
            set { this.numero = value; }
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
        public string MUNICIPIO
        {
            get { return this.municipio; }
            set { this.municipio = value; }
        }
        public bool ESTADO
        {
            get { return this.estado; }
            set { this.estado = value; }
        }
        #endregion
    }
}