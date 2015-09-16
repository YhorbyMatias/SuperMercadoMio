using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent
{
    public class IngresoEnt
    {
        #region Atributos
        private int id_ingreso;
        private int id_proveedor;
        private string fecha;
        private int numero_de_registro;
        private string numero_de_nota_de_entrega;
        private decimal monto;
        private string observaciones;
        private string estado;
        #endregion
        #region Propiedades
        public int ID_INGRESO
        {
            get { return this.id_ingreso; }
            set { this.id_ingreso = value; }
        }
        public int ID_PROVEEDOR
        {
            get { return this.id_proveedor; }
            set { this.id_proveedor = value; }
        }
        public string FECHA
        {
            get { return this.fecha; }
            set { this.fecha = value; }
        }
        public int NUMERO_DE_REGISTRO
        {
            get { return this.numero_de_registro; }
            set { this.numero_de_registro = value; }
        }
        public string NUMERO_DE_NOTA_DE_ENTREGA
        {
            get { return this.numero_de_nota_de_entrega; }
            set { this.numero_de_nota_de_entrega = value; }
        }
        public decimal MONTO
        {
            get { return this.monto; }
            set { this.monto = value; }
        }
        public string OBSERVACIONES
        {
            get { return this.observaciones; }
            set { this.observaciones = value; }
        }
        public string ESTADO
        {
            get { return this.estado; }
            set { this.estado = value; }
        }
        #endregion
    }
}