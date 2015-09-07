using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent
{
    public class DosificacionEnt
    {
        #region Atributos
        private int id_dosificacion;
        private int id_sucursal;
        private string numero_de_autorizacion;
        private string llave;
        private string fecha_limite_de_emision;
        private string leyenda;
        private string estado;
        #endregion
        #region Propiedades
        public int ID_DOSIFICACION
        {
            get { return this.id_dosificacion; }
            set { this.id_dosificacion = value; }
        }
        public int ID_SUCURSAL
        {
            get { return this.id_sucursal; }
            set { this.id_sucursal = value; }
        }
        public string NUMERO_DE_AUTORIZACION
        {
            get { return this.numero_de_autorizacion; }
            set { this.numero_de_autorizacion = value; }
        }
        public string LLAVE
        {
            get { return this.llave; }
            set { this.llave = value; }
        }
        public string FECHA_LIMITE_DE_EMISION
        {
            get { return this.fecha_limite_de_emision; }
            set { this.fecha_limite_de_emision = value; }
        }
        public string LEYENDA
        {
            get { return this.leyenda; }
            set { this.leyenda = value; }
        }
        public string ESTADO
        {
            get { return this.estado; }
            set { this.estado = value; }
        }
        #endregion
    }
}