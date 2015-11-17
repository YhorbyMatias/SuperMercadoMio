using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent
{
    public class AperturaDeCajaEnt
    {
        #region Atributos
        private int id;
        private int id_usuario;
        private int id_caja;
        private string fecha;
        private string hora;
        private decimal monto;
        private bool cerrado;
        #endregion
        #region Propiedades
        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public int ID_USUARIO
        {
            get { return this.ID_USUARIO; }
            set { this.ID_USUARIO = value; }
        }
        public int ID_CAJA
        {
            get { return this.id_caja; }
            set { this.id_caja = value; }
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
        #endregion
    }
}