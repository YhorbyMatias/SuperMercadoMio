using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent
{
    public class FacturaEnt
    {
        #region Atributos
        private int id;
        private int id_usuario;
        private int id_caja;
        private int id_apertura_de_caja;
        private int id_egreso;
        private int id_cliente;
        private int id_dosificacion;
        private string numero_de_autorizacion;
        private int numero_de_factura;
        private string codigo_de_control;
        private string ci_o_nit;
        private string cliente;
        private string fecha;
        private string hora;
        private decimal monto;
        private decimal monto_pagado;
        private decimal cambio;
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
        public int ID_EGRESO
        {
            get { return this.id_egreso; }
            set { this.id_egreso = value; }
        }
        public int ID_CLIENTE
        {
            get { return this.id_cliente; }
            set { this.id_cliente = value; }
        }
        public int ID_DOSIFICACION
        {
            get { return this.id_dosificacion; }
            set { this.id_dosificacion = value; }
        }
        public string NUMERO_DE_AUTORIZACION
        {
            get { return this.numero_de_autorizacion; }
            set { this.numero_de_autorizacion = value; }
        }
        public int NUMERO_DE_FACTURA
        {
            get { return this.numero_de_factura; }
            set { this.numero_de_factura = value; }
        }
        public string CODIGO_DE_CONTROL
        {
            get { return this.codigo_de_control; }
            set { this.codigo_de_control = value; }
        }
        public string CI_O_NIT
        {
            get { return this.ci_o_nit; }
            set { this.ci_o_nit = value; }
        }
        public string CLIENTE
        {
            get { return this.cliente; }
            set { this.cliente = value; }
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
        public string ESTADO
        {
            get { return this.estado; }
            set { this.estado = value; }
        }
        #endregion
    }
}