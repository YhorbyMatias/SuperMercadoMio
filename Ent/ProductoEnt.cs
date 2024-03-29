﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent
{
    public class ProductoEnt
    {
        #region Atributos
        private int id;
        private int id_proveedor;
        private int id_grupo;
        private string tipo_de_codigo_de_barras;
        private string codigo_de_barras;
        private string nombre_generico;
        private string marca;
        private string presentacion;
        private string sabor_u_olor;
        private string tipo;
        private decimal cantidad_minima;
        private decimal precio_de_compra;
        private decimal precio_de_venta;
        private string alias;
        private bool estado;
        #endregion
        #region Propiedades
        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public int ID_PROVEEDOR
        {
            get { return this.id_proveedor; }
            set { this.id_proveedor = value; }
        }
        public int ID_GRUPO
        {
            get { return this.id_grupo; }
            set { this.id_grupo = value; }
        }
        public string TIPO_DE_CODIGO_DE_BARRAS
        {
            get { return this.tipo_de_codigo_de_barras; }
            set { this.tipo_de_codigo_de_barras = value; }
        }
        public string CODIGO_DE_BARRAS
        {
            get { return this.codigo_de_barras; }
            set { this.codigo_de_barras = value; }
        }
        public string NOMBRE_GENERICO
        {
            get { return this.nombre_generico; }
            set { this.nombre_generico = value; }
        }
        public string MARCA
        {
            get { return this.marca; }
            set { this.marca = value; }
        }
        public string PRESENTACION
        {
            get { return this.presentacion; }
            set { this.presentacion = value; }
        }
        public string SABOR_U_OLOR
        {
            get { return this.sabor_u_olor; }
            set { this.sabor_u_olor = value; }
        }
        public string TIPO
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }
        public decimal CANTIDAD_MINIMA
        {
            get { return this.cantidad_minima; }
            set { this.cantidad_minima = value; }
        }
        public decimal PRECIO_DE_COMPRA
        {
            get { return this.precio_de_compra; }
            set { this.precio_de_compra = value; }
        }
        public decimal PRECIO_DE_VENTA
        {
            get { return this.precio_de_venta; }
            set { this.precio_de_venta = value; }
        }
        public string ALIAS
        {
            get { return this.alias; }
            set { this.alias = value; }
        }
        public bool ESTADO
        {
            get { return this.estado; }
            set { this.estado = value; }
        }
        #endregion
    }
}