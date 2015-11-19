using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent
{
    public class DetalleDeFacturaEnt
    {
        #region Atributos
        private int id;
        private int id_factura;
        private int id_producto;
        private string detalle;
        private decimal cantidad;
        private decimal importe;
        private bool estado;
        #endregion
        #region Propiedades
        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public int ID_FACTURA
        {
            get { return this.id_factura; }
            set { this.id_factura = value; }
        }
        public int ID_PRODUCTO
        {
            get { return this.id_producto; }
            set { this.id_producto = value; }
        }
        public string DETALLE
        {
            get { return this.detalle; }
            set { this.detalle = value; }
        }
        public decimal CANTIDAD
        {
            get { return this.cantidad; }
            set { this.cantidad = value; }
        }
        public decimal IMPORTE
        {
            get { return this.importe; }
            set { this.importe = value; }
        }
        public bool ESTADO
        {
            get { return this.estado; }
            set { this.estado = value; }
        }
        #endregion
    }
}