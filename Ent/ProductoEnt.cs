using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent
{
    public class ProductoEnt
    {
        #region Atributos
        private int id_producto;
        private int id_proveedor;
        private int id_grupo;
        private string tipo_de_codigo_de_barras;
        private string codigo_de_barras;
        private string nombre_generico;
        private string marca;
        private string presentacion;
        private string alias;
        private string sabor_u_olor;
        private string tipo;
        private decimal cantidad_minima;
        private decimal precio;
        private bool estado;
        #endregion
        #region Propiedades
        public int ID_PRODUCTO
        {
            get { return this.id_producto; }
            set { this.id_producto = value; }
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
        public string ALIAS
        {
            get { return this.alias; }
            set { this.alias = value; }
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
        public decimal PRECIO
        {
            get { return this.precio; }
            set { this.precio = value; }
        }
        public bool ESTADO
        {
            get { return this.estado; }
            set { this.estado = value; }
        }
        #endregion
        #region Atributos Auxiliares
        private string proveedor;
        private string grupo;
        #endregion
        #region Propiedades Auxiliares
        public string PROVEEDOR
        {
            get { return this.proveedor; }
            set { this.proveedor = value; }
        }
        public string GRUPO
        {
            get { return this.grupo; }
            set { this.grupo = value; }
        }
        #endregion
    }
}