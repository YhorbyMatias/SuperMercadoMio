using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent
{
    public class CierreDeCajaEnt
    {
        #region Atributos
        private int id;
        private int id_usuario;
        private int id_caja;
        private int id_apertura_de_caja;
        private string fecha;
        private string hora;
        private decimal monto_de_apertura_de_caja;
        private decimal monto_de_ventas;
        private decimal monto_de_cupones;
        private decimal monto_de_devoluciones;
        private decimal monto_de_venta_de_tarjetas;
        private decimal monto_de_pagos;
        private decimal monto_total;
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
        public decimal MONTO_DE_APERTURA_DE_CAJA
        {
            get { return this.monto_de_apertura_de_caja; }
            set { this.monto_de_apertura_de_caja = value; }
        }
        public decimal MONTO_DE_VENTAS
        {
            get { return this.monto_de_ventas; }
            set { this.monto_de_ventas = value; }
        }
        public decimal MONTO_DE_CUPONES
        {
            get { return this.monto_de_cupones; }
            set { this.monto_de_cupones = value; }
        }
        public decimal MONTO_DE_DEVOLUCIONES
        {
            get { return this.monto_de_devoluciones; }
            set { this.monto_de_devoluciones = value; }
        }
        public decimal MONTO_DE_VENTA_DE_TARJETAS
        {
            get { return this.monto_de_venta_de_tarjetas; }
            set { this.monto_de_venta_de_tarjetas = value; }
        }
        public decimal MONTO_DE_PAGOS
        {
            get { return this.monto_de_pagos; }
            set { this.monto_de_pagos = value; }
        }
        public decimal MONTO_TOTAL
        {
            get { return this.monto_total; }
            set { this.monto_total = value; }
        }
        #endregion
    }
}