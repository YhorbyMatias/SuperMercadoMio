using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent
{
    public class DevolucionEnt
    {
        #region Atributos
        private int id;
        private int id_usuario;
        private int id_caja;
        private int id_apertura_de_caja;
        private int id_egreso;
        private string fecha;
        private string hora;
        private decimal monto;
        private bool cerrado;
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
        public int ID_CAJA
        {
            get { return this.id_caja; }
            set { this.id_caja = value; }
        }
        public int ID_APERTURA_DE_CAJA
        {
            get { return this.id_apertura_de_caja; }
            set { this.id_apertura_de_caja = value; }
        }
        public int ID_EGRESO
        {
            get { return this.id_egreso; }
            set { this.id_egreso = value; }
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
        public decimal MONTO
        {
            get { return this.monto; }
            set { this.monto = value; }
        }
        public bool CERRADO
        {
            get { return this.cerrado; }
            set { this.cerrado = value; }
        }
        public bool ESTADO
        {
            get { return this.estado; }
            set { this.estado = value; }
        }
        #endregion
    }
}