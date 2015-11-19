using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bss
{
    public class Base64Bss
    {
        #region Objetos
        string[] Dicionario = new string[64] {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9",
                                             "A", "B", "C", "D", "E", "F", "G", "H", "I", "J",
                                             "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T",
                                             "U", "V", "W", "X", "Y", "Z", "a", "b", "c", "d",
                                             "e", "f", "g", "h", "i", "j", "k", "l", "m", "n",
                                             "o", "p", "q", "r", "s", "t", "u", "v", "w", "x",
                                             "y", "z", "+", "/" };
        #endregion
        #region Metodos
        public string ObtenerBase64(int Numero)
        {
            int cociente = 1;
            int resto = 0;
            string palabra = "";
            while (cociente > 0)
            {
                cociente = Numero / 64;
                resto = Numero % 64;
                palabra = Dicionario[resto] + palabra;
                Numero = cociente;
            }
            return palabra;
        }
        #endregion
    }
}