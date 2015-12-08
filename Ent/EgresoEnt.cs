using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent
{
    public class EgresoEnt
    {
        #region Atributos
        private int id;
        private int id_usuario;
        private int id_caja;
        private int id_apertura_de_caja;
        private int id_cliente;
        private string fecha;
        private string hora;
        private string tipo;
        private int numero_de_registro;
        private string metodo_de_pago;
        private decimal monto;
        private decimal monto_de_cupon;
        private decimal monto_extra;
        private decimal monto_pagado;
        private decimal cambio;
        private string observaciones;
        private bool facturado;
        private bool cerrado;
        private string estado;
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
        public int ID_CLIENTE
        {
            get { return this.id_cliente; }
            set { this.id_cliente = value; }
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
        public string TIPO
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }
        public int NUMERO_DE_REGISTRO
        {
            get { return this.numero_de_registro; }
            set { this.numero_de_registro = value; }
        }
        public string METODO_DE_PAGO
        {
            get { return this.metodo_de_pago; }
            set { this.metodo_de_pago = value; }
        }
        public decimal MONTO
        {
            get { return this.monto; }
            set { this.monto = value; }
        }
        public decimal MONTO_DE_CUPON
        {
            get { return this.monto_de_cupon; }
            set { this.monto_de_cupon = value; }
        }
        public decimal MONTO_EXTRA
        {
            get { return this.monto_extra; }
            set { this.monto_extra = value; }
        }
        public decimal MONTO_PAGADO
        {
            get { return this.monto_pagado; }
            set { this.monto_pagado = value; }
        }
        public decimal CAMBIO
        {
            get { return this.cambio; }
            set { this.cambio = value; }
        }
        public string OBSERVACIONES
        {
            get { return this.observaciones; }
            set { this.observaciones = value; }
        }
        public bool FACTURADO
        {
            get { return this.facturado; }
            set { this.facturado = value; }
        }
        public bool CERRADO
        {
            get { return this.cerrado; }
            set { this.cerrado = value; }
        }
        public string ESTADO
        {
            get { return this.estado; }
            set { this.estado = value; }
        }
        #endregion
    }
}