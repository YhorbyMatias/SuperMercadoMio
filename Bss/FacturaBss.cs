using Dal;
using Ent;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bss
{
    public class FacturaBss
    {
        #region Objects
        FacturaDal objetoFactura = new FacturaDal();
        VerhoeffBss objetoVerhoeff = new VerhoeffBss();
        AllegedRC4Bss objetoallegedrc4 = new AllegedRC4Bss();
        Base64Bss objetobase64 = new Base64Bss();
        List<DetalleDeFacturaEnt> listDetalleDeFactura = new List<DetalleDeFacturaEnt>();
        #endregion
        #region Public Methods
        public int add(FacturaEnt factura)
        {
            int id = objetoFactura.add(factura);
            DetalleDeFacturaBss objetoDetalleDeFactura = new DetalleDeFacturaBss();
            foreach (DetalleDeFacturaEnt detalleDeFactura in this.listDetalleDeFactura)
            {
                detalleDeFactura.ID_FACTURA = id;
                objetoDetalleDeFactura.add(detalleDeFactura);
            }
            this.listDetalleDeFactura.Clear();
            return id;
        }
        public int getNumber(FacturaEnt factura)
        {
            return objetoFactura.getNumber(factura);
        }
        public void updateControlCode(FacturaEnt factura)
        {
            objetoFactura.updateControlCode(factura);
        }
        public void addDetalle(DetalleDeFacturaEnt detalleDeFactura)
        {
            bool existe = false;
            int row = 0;
            for (int rowIndex = 0; rowIndex < this.listDetalleDeFactura.Count; rowIndex++)
            {
                if (detalleDeFactura.ID_PRODUCTO == this.listDetalleDeFactura[rowIndex].ID_PRODUCTO)
                {
                    existe = true;
                    row = rowIndex;
                    break;
                }
            }
            if (existe == false)
            {
                this.listDetalleDeFactura.Add(detalleDeFactura);
            }
            else
            {
                this.listDetalleDeFactura[row].CANTIDAD = this.listDetalleDeFactura[row].CANTIDAD + detalleDeFactura.CANTIDAD;
                this.listDetalleDeFactura[row].IMPORTE = this.listDetalleDeFactura[row].IMPORTE + detalleDeFactura.IMPORTE;
            }
        }
        public string getControlCode(FacturaEnt factura)
        {
            factura.MONTO_AUXILIAR = factura.MONTO.ToString("##").ToString();
            factura.NUMERO_AUXILIAR = getVerhoeff(2, factura.NUMERO_AUXILIAR);
            factura.CI_O_NIT_AUXILIAR = getVerhoeff(2, factura.CI_O_NIT_AUXILIAR);
            factura.FECHA_AUXILIAR = getVerhoeff(2, factura.FECHA_AUXILIAR);
            factura.MONTO_AUXILIAR = getVerhoeff(2, factura.MONTO_AUXILIAR);

            string cincodigitosverhoeff = getVerhoeff(5, (Convert.ToDouble(factura.NUMERO_AUXILIAR)
                + Convert.ToDouble(factura.CI_O_NIT_AUXILIAR) + Convert.ToDouble(factura.FECHA_AUXILIAR)
                + Convert.ToDouble(factura.MONTO_AUXILIAR)).ToString());

            string cadena1 = getString(cincodigitosverhoeff, factura.LLAVE, 0);
            string cadena2 = getString(cincodigitosverhoeff, factura.LLAVE, 1);
            string cadena3 = getString(cincodigitosverhoeff, factura.LLAVE, 2);
            string cadena4 = getString(cincodigitosverhoeff, factura.LLAVE, 3);
            string cadena5 = getString(cincodigitosverhoeff, factura.LLAVE, 4);

            cadena1 = factura.NUMERO_DE_AUTORIZACION_AUXILIAR + cadena1;
            cadena2 = factura.NUMERO_AUXILIAR + cadena2;
            cadena3 = factura.CI_O_NIT_AUXILIAR + cadena3;
            cadena4 = factura.FECHA_AUXILIAR + cadena4;
            cadena5 = factura.MONTO_AUXILIAR + cadena5;

            string cadena = cadena1 + cadena2 + cadena3 + cadena4 + cadena5;
            cadena = objetoallegedrc4.AllegedRC4(cadena, factura.LLAVE + cincodigitosverhoeff);
            int numero = getAsciiSum(cadena, cincodigitosverhoeff);
            string codigo = objetobase64.ObtenerBase64(numero);
            codigo = objetoallegedrc4.AllegedRC4(codigo, factura.LLAVE + cincodigitosverhoeff);
            return getFinalCodeControl(codigo);
        }
        public DataTable obtainById(FacturaEnt factura)
        {
            return objetoFactura.obtainById(factura);
        }
        #endregion
        #region Private Methods
        private int getAsciiSum(string word, string verhoeffFiveDigits)
        {
            int auxiliar = 0;
            int auxiliar2 = 0;
            int numero1 = 0;
            int numero2 = 0;
            int numero3 = 0;
            int numero4 = 0;
            int numero5 = 0;
            int total = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = i; j < word.Length; j = j + 5)
                {
                    auxiliar = auxiliar + Convert.ToInt32(word[j]);
                    auxiliar2 = auxiliar2 + Convert.ToInt32(word[j]);
                }
                if (i == 0) { numero1 = auxiliar; }
                if (i == 1) { numero2 = auxiliar; }
                if (i == 2) { numero3 = auxiliar; }
                if (i == 3) { numero4 = auxiliar; }
                if (i == 4) { numero5 = auxiliar; }
                auxiliar = 0;
            }
            for (int i = 0; i < verhoeffFiveDigits.Length; i++)
            {
                if (i == 0) { auxiliar = numero1 * auxiliar2 / (Convert.ToInt32(verhoeffFiveDigits[i].ToString()) + 1); }
                if (i == 1) { auxiliar = numero2 * auxiliar2 / (Convert.ToInt32(verhoeffFiveDigits[i].ToString()) + 1); }
                if (i == 2) { auxiliar = numero3 * auxiliar2 / (Convert.ToInt32(verhoeffFiveDigits[i].ToString()) + 1); }
                if (i == 3) { auxiliar = numero4 * auxiliar2 / (Convert.ToInt32(verhoeffFiveDigits[i].ToString()) + 1); }
                if (i == 4) { auxiliar = numero5 * auxiliar2 / (Convert.ToInt32(verhoeffFiveDigits[i].ToString()) + 1); }

                total = total + auxiliar;
            }
            return total;
        }
        private string getFinalCodeControl(string code)
        {
            string codigo = "";
            for (int i = 0; i < code.Length; i++)
            {
                if (i > 0 && i % 2 == 0)
                {
                    codigo = codigo + "-";
                }
                codigo = codigo + code[i];
            }
            return codigo;
        }
        private string getString(string CincoDigitosVerhoeffX, string LlaveX, int Posicion)
        {
            int contador = 0;
            string cadena = "";
            for (int i = 0; i < CincoDigitosVerhoeffX.Length; i++)
            {
                if (i == Posicion)
                {
                    cadena = LlaveX.Substring(contador, Convert.ToInt32(CincoDigitosVerhoeffX[i].ToString()) + 1);
                    break;
                }
                contador = contador + Convert.ToInt32(CincoDigitosVerhoeffX[i].ToString()) + 1;
            }
            return cadena;
        }
        private string getVerhoeff(int quantity, string figure)
        {
            string cadena;
            string auxiliar = "";
            for (int i = 0; i < quantity; i++)
            {
                cadena = objetoVerhoeff.GenerarVerhoeff(figure);
                figure = figure + cadena;
                auxiliar = auxiliar + cadena;
            }
            if (quantity == 5)
            {
                return auxiliar;
            }
            else
            {
                return figure;
            }
        }
        #endregion
    }
}