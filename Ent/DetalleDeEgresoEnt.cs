using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent
{
    public class DetalleDeEgresoEnt
    {
        #region Atributos
        private int id;
        private int id_egreso;
        private int id_producto;
        private decimal cantidad;
        private decimal precio_unitario;
        private decimal monto_total;
        private string estado;
        #endregion
        #region Propiedades
        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public int ID_EGRESO
        {
            get { return this.id_egreso; }
            set { this.id_egreso = value; }
        }
        public int ID_PRODUCTO
        {
            get { return this.id_producto; }
            set { this.id_producto = value; }
        }
        public decimal CANTIDAD
        {
            get { return this.cantidad; }
            set { this.cantidad = value; }
        }
        public decimal PRECIO_UNITARIO
        {
            get { return this.precio_unitario; }
            set { this.precio_unitario = value; }
        }
        public decimal MONTO_TOTAL
        {
            get { return this.monto_total; }
            set { this.monto_total = value; }
        }
        public string ESTADO
        {
            get { return this.estado; }
            set { this.estado = value; }
        }
        #endregion
    }
}