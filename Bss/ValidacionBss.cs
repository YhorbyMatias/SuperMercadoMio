﻿using System;
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
        public static string diccionarioCadena = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz áéíóúÁÉÍÓÚÑñ.";
        #endregion
        #region Metodos
        public static string getErrorMessage(int errorCodeX)
        {
            string errorMessage = "";
            switch(errorCodeX)
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
            }
            return errorMessage;
        }
        public static bool esCadena(string cadenaX)
        {
            return Regex.IsMatch(cadenaX, @"^[a-zA-Z áéíóúÁÉÍÓÚÑñ.]+$");
        }
        public static bool esCelular(string CadenaX)
        {
            bool bandera;
            bandera = Regex.IsMatch(CadenaX, @"^([6-7])\d{7}$");
            return bandera;
        }
        public static bool esCelularOTelefono(string cadenaX)
        {
            return Regex.IsMatch(cadenaX, @"^([6-7])\d{7}$|^[0-9]{7,8}$");
        }
        public static bool esCi(string cadenaX)
        {
            return Regex.IsMatch(cadenaX, @"^[0-9]{4,8}$|[0]$|[00]$");
        }
        public static bool esEntero(string cadenaX)
        {
            return Regex.IsMatch(cadenaX, @"^\d+$");
        }
        public static bool esNit(string cadenaX)
        {
            return Regex.IsMatch(cadenaX, @"^\d{9,12}$");
        }
        public static bool esRealConDosDecimales(string CadenaX)
        {
            bool bandera;
            bandera = Regex.IsMatch(CadenaX, @"^\d+$|\d+\.\d{1,2}$");
            return bandera;
        }
        public static bool esRealConTresDecimales(string CadenaX)
        {
            bool bandera;
            bandera = Regex.IsMatch(CadenaX, @"^\d+$|\d+\.\d{1,3}$");
            return bandera;
        }
        public static bool esTelefono(string cadenaX)
        {
            bool bandera;
            bandera = Regex.IsMatch(cadenaX, @"^[0-9]{7,8}$");
            return bandera;
        }
        #endregion
    }
}