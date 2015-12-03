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
        public static string controlCodeDictionary = "ABCDEFabcdef0123456789";
        public static string diccionarioCadena = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz áéíóúÁÉÍÓÚÑñ.,";
        public static string diccionarioLlave = @"ABCDEFGHIJKLMNPQRSTUVWXYZabcdefghijkmnpqrstuvwxyz23456789=#()*+-_\@[]{}%$";
        #endregion
        #region Metodos
        public static string getErrorMessage(int errorCode)
        {
            string errorMessage = "";
            switch (errorCode)
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
                    errorMessage = "El valor del campo debe ser mayor o igual a cero.";
                    break;
                //User Errors
                case 110:
                    errorMessage = "El CI ya se halla registrado.";
                    break;
                case 111:
                    errorMessage = "El usuario ya se halla registrado.";
                    break;
                case 112:
                    errorMessage = "El nombre de usuario ya se halla registrado.";
                    break;
                //Dosificacion Errors
                case 200:
                    errorMessage = "El número de autorización ya se halla registrado.";
                    break;
                //Caja Errors
                case 300:
                    errorMessage = "El número ya se halla registrado.";
                    break;
                case 301:
                    errorMessage = "El monto total no puede ser negativo.";
                    break;
                //Provider Errors
                case 400:
                    errorMessage = "El NIT ya se halla registrado.";
                    break;
                case 401:
                    errorMessage = "El proveedor ya se halla registrado.";
                    break;
                //Client Errors
                case 500:
                    errorMessage = "El Ci o Nit ya se halla registrado.";
                    break;
                case 501:
                    errorMessage = "El cliente ya se halla registrado.";
                    break;
                //Group Errors
                case 600:
                    errorMessage = "El grupo ya se halla registrado.";
                    break;
                //Product Screens
                case 700:
                    errorMessage = "El código de barras ya se halla registrado.";
                    break;
                case 701:
                    errorMessage = "El producto ya se halla registrado.";
                    break;
                case 702:
                    errorMessage = "El precio de compra debe ser menor al precio de venta.";
                    break;
                case 703:
                    errorMessage = "El alias ya se halla registrado.";
                    break;
                //Purchase Errors
                case 800:
                    errorMessage = "Revise el nit del proveedor.";
                    break;
                case 801:
                    errorMessage = "No se agregó ningún producto.";
                    break;
                case 802:
                    errorMessage = "El precio de compra debe ser menor al precio de venta.";
                    break;
                //Sales Errors
                case 900:
                    errorMessage = "No se agregó ningún producto.";
                    break;
                case 901:
                    errorMessage = "Revise el CI del cliente.";
                    break;
                case 902:
                    errorMessage = "El monto pagado no puede ser menor al monto total.";
                    break;
                case 903:
                    errorMessage = "El monto de una 'Venta Menor' debe ser inferior a 5 Bs.";
                    break;
                case 904:
                    errorMessage = "Elija el cliente '0' o ingrese el CI ó Nit del cliente";
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
        public static bool esCiONit(string value)
        {
            return Regex.IsMatch(value, @"^\d{4,12}$|[0]$|[00]$");
        }
        public static bool isDigitOrControl(char value)
        {
            if (char.IsDigit(value))
            {
                return true;
            }
            else
            {
                if (Char.IsControl(value))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool esEntero(string value)
        {
            return Regex.IsMatch(value, @"^\d+$");
        }
        public static bool esLlaveDeDosificacion(string value)
        {
            return Regex.IsMatch(value, @"^[a-zA-Z23456789=#()*\+\-_\\@[\]{}%$]+$");
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
        public static bool isControlCode(string value)
        {
            return Regex.IsMatch(value, @"^(([0-9A-F][0-9A-F]\-)([0-9A-F][0-9A-F]\-)([0-9A-F][0-9A-F]\-)"
                + @"([0-9A-F][0-9A-F])((\-[0-9A-F][0-9A-F])||((\-[0-9A-F][0-9A-F])(\-[0-9A-F][0-9A-F]))))$");
        }
        #endregion
    }
}