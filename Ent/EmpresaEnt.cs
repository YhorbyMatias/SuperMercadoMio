using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent
{
    public class EmpresaEnt
    {
        #region Atributos
        private int id_empresa;
        private string razon_social;
        private string nit;
        private string actividad_economica;
        private string propietario;
        private bool estado;
        #endregion
        #region Propiedades
        public int ID_EMPRESA
        {
            get { return this.id_empresa; }
            set { this.id_empresa = value; }
        }
        public string RAZON_SOCIAL
        {
            get { return this.razon_social; }
            set { this.razon_social = value; }
        }
        public string NIT
        {
            get { return this.nit; }
            set { this.nit = value; }
        }
        public string ACTIVIDAD_ECONOMICA
        {
            get { return this.actividad_economica; }
            set { this.actividad_economica = value; }
        }
        public string PROPIETARIO
        {
            get { return this.propietario; }
            set { this.propietario = value; }
        }
        public bool ESTADO
        {
            get { return this.estado; }
            set { this.estado = value; }
        }
        #endregion
    }
}