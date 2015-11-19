using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bss
{
    public class LiteralBss
    {
        #region Methods
        private string aLiteral(double value)
        {
            string resultado = "";
            value = Math.Truncate(value);
            if (value == 0) resultado = "CERO";
            else if (value == 1) resultado = "UNO";
            else if (value == 2) resultado = "DOS";
            else if (value == 3) resultado = "TRES";
            else if (value == 4) resultado = "CUATRO";
            else if (value == 5) resultado = "CINCO";
            else if (value == 6) resultado = "SEIS";
            else if (value == 7) resultado = "SIETE";
            else if (value == 8) resultado = "OCHO";
            else if (value == 9) resultado = "NUEVE";
            else if (value == 10) resultado = "DIEZ";
            else if (value == 11) resultado = "ONCE";
            else if (value == 12) resultado = "DOCE";
            else if (value == 13) resultado = "TRECE";
            else if (value == 14) resultado = "CATORCE";
            else if (value == 15) resultado = "QUINCE";
            else if (value < 20) resultado = "DIECI" + aLiteral(value - 10);
            else if (value == 20) resultado = "VEINTE";
            else if (value < 30) resultado = "VEINTI" + aLiteral(value - 20);
            else if (value == 30) resultado = "TREINTA";
            else if (value == 40) resultado = "CUARENTA";
            else if (value == 50) resultado = "CINCUENTA";
            else if (value == 60) resultado = "SESENTA";
            else if (value == 70) resultado = "SETENTA";
            else if (value == 80) resultado = "OCHENTA";
            else if (value == 90) resultado = "NOVENTA";
            else if (value < 100) resultado = aLiteral(Math.Truncate(value / 10) * 10) + " Y " + aLiteral(value % 10);
            else if (value == 100) resultado = "CIEN";
            else if (value < 200) resultado = "CIENTO " + aLiteral(value - 100);
            else if ((value == 200) || (value == 300) || (value == 400) || (value == 600) || (value == 800)) resultado = aLiteral(Math.Truncate(value / 100)) + "CIENTOS";
            else if (value == 500) resultado = "QUINIENTOS";
            else if (value == 700) resultado = "SETECIENTOS";
            else if (value == 900) resultado = "NOVECIENTOS";
            else if (value < 1000) resultado = aLiteral(Math.Truncate(value / 100) * 100) + " " + aLiteral(value % 100);
            else if (value == 1000) resultado = "MIL";
            else if (value < 2000) resultado = "MIL " + aLiteral(value % 1000);
            else if (value < 1000000)
            {
                resultado = aLiteral(Math.Truncate(value / 1000)) + " MIL";
                if ((value % 1000) > 0) resultado = resultado + " " + aLiteral(value % 1000);
            }
            else if (value == 1000000) resultado = "UN MILLON";
            else if (value < 2000000) resultado = "UN MILLON " + aLiteral(value % 1000000);
            else if (value < 1000000000000)
            {
                resultado = aLiteral(Math.Truncate(value / 1000000)) + " MILLONES ";
                if ((value - Math.Truncate(value / 1000000) * 1000000) > 0) resultado = resultado + " " + aLiteral(value - Math.Truncate(value / 1000000) * 1000000);
            }
            else if (value == 1000000000000) resultado = "UN BILLON";
            else if (value < 2000000000000) resultado = "UN BILLON " + aLiteral(value - Math.Truncate(value / 1000000000000) * 1000000000000);
            else
            {
                resultado = aLiteral(Math.Truncate(value / 1000000000000)) + " BILLONES";
                if ((value - Math.Truncate(value / 1000000000000) * 1000000000000) > 0) resultado = resultado + " " + aLiteral(value - Math.Truncate(value / 1000000000000) * 1000000000000);
            }
            return resultado;
        }
        public string convertirALiteral(string number)
        {
            string cadenaresultado, cadenadecimales = "";
            Int64 entero;
            int decimales;
            double numero;
            numero = Convert.ToDouble(number);
            entero = Convert.ToInt64(Math.Truncate(numero));
            decimales = Convert.ToInt32(Math.Round((numero - entero) * 100, 2));
            cadenadecimales = " CON " + decimales.ToString("D2") + "/100 Bs.";
            cadenaresultado = aLiteral(Convert.ToDouble(entero)) + cadenadecimales;
            return cadenaresultado;
        }
        #endregion
    }
}