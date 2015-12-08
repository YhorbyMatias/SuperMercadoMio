using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent
{
    public class DetalleDeIngresoEnt
    {
        #region Atributos
        private int id;
        private int id_ingreso;
        private int id_producto;
        private decimal cantidad;
        private decimal precio_de_compra;
        private decimal monto_total;
        private decimal porcentaje_de_utilidad;
        private decimal precio_de_venta;
        private string estado;
        #endregion
        #region Propiedades
        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public int ID_INGRESO
        {
            get { return this.id_ingreso; }
            set { this.id_ingreso = value; }
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
        public decimal PRECIO_DE_COMPRA
        {
            get { return this.precio_de_compra; }
            set { this.precio_de_compra = value; }
        }
        public decimal MONTO_TOTAL
        {
            get { return this.monto_total; }
            set { this.monto_total = value; }
        }
        public decimal PORCENTAJE_DE_UTILIDAD
        {
            get { return this.porcentaje_de_utilidad; }
            set { this.porcentaje_de_utilidad = value; }
        }
        public decimal PRECIO_DE_VENTA
        {
            get { return this.precio_de_venta; }
            set { this.precio_de_venta = value; }
        }
        public string ESTADO
        {
            get { return this.estado; }
            set { this.estado = value; }
        }
        #endregion
    }
}