using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bss
{
    public class ValidacionBss
    {
        #region Atributos
        public static string diccionarioCadena = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz áéíóúÁÉÍÓÚÑñ.,";
        #endregion
        #region Metodos
        public static string getErrorMessage(int errorCode)
        {
            string errorMessage = "";
            switch(errorCode)
            {
                case 0:
                    errorMessage = null;
                    break;
                case 1:
                    errorMessage = "Este campo es obligatorio.";
                    break;
                case 2:
                    errorMessage = "El valor del campo no es correcto.";
                    break;
                case 3:
                    errorMessage = "No se seleccionó niguna opción.";
                    break;
                case 4:
                    errorMessage = "El CI ya se halla registrado.";
                    break;
                case 5:
                    errorMessage = "El usuario ya se halla registrado.";
                    break;
                case 6:
                    errorMessage = "El nombre de usuario ya se halla registrado.";
                    break;
                case 7:
                    errorMessage = "El NIT ya se halla registrado.";
                    break;
                case 8:
                    errorMessage = "El grupo ya se halla registrado.";
                    break;
                case 9:
                    errorMessage = "El código de barras ya se halla registrado.";
                    break;
                case 10:
                    errorMessage = "El producto ya se halla registrado.";
                    break;
                case 11:
                    errorMessage = "El alias ya se halla registrado.";
                    break;
                case 12:
                    errorMessage = "El precio de compra debe ser menor al precio de venta.";
                    break;
                case 13:
                    errorMessage = "Revise el nit del proveedor.";
                    break;
                case 14:
                    errorMessage = "No se agregó ningún producto.";
                    break;
            }
            return errorMessage;
        }
        public static bool esCadena(string value)
        {
            return Regex.IsMatch(value, @"^[a-zA-Z áéíóúÁÉÍÓÚÑñ.,]+$");
        }
        public static bool esCelular(string value)
        {
            bool bandera;
            bandera = Regex.IsMatch(value, @"^([6-7])\d{7}$");
            return bandera;
        }
        public static bool esCelularOTelefono(string value)
        {
            return Regex.IsMatch(value, @"^([6-7])\d{7}$|^[0-9]{7,8}$");
        }
        public static bool esCi(string value)
        {
            return Regex.IsMatch(value, @"^[0-9]{4,8}$|[0]$|[00]$");
        }
        public static bool esEntero(string value)
        {
            return Regex.IsMatch(value, @"^\d+$");
        }
        public static bool esNit(string value)
        {
            return Regex.IsMatch(value, @"^\d{9,12}$");
        }
        public static bool esRealConDosDecimales(string value)
        {
            bool bandera;
            bandera = Regex.IsMatch(value, @"^\d+$|\d+\.\d{1,2}$");
            return bandera;
        }
        public static bool esRealConTresDecimales(string value)
        {
            bool bandera;
            bandera = Regex.IsMatch(value, @"^\d+$|\d+\.\d{1,3}$");
            return bandera;
        }
        public static bool esTelefono(string value)
        {
            bool bandera;
            bandera = Regex.IsMatch(value, @"^[0-9]{7,8}$");
            return bandera;
        }
        #endregion
    }
}