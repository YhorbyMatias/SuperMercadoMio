using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bss
{
    public class VerhoeffBss
    {
        #region Tablas
        // The multiplication table
        int[,] Multiplicacion = new int[,]
        {
            {0, 1, 2, 3, 4, 5, 6, 7, 8, 9}, 
            {1, 2, 3, 4, 0, 6, 7, 8, 9, 5}, 
            {2, 3, 4, 0, 1, 7, 8, 9, 5, 6}, 
            {3, 4, 0, 1, 2, 8, 9, 5, 6, 7}, 
            {4, 0, 1, 2, 3, 9, 5, 6, 7, 8}, 
            {5, 9, 8, 7, 6, 0, 4, 3, 2, 1}, 
            {6, 5, 9, 8, 7, 1, 0, 4, 3, 2}, 
            {7, 6, 5, 9, 8, 2, 1, 0, 4, 3}, 
            {8, 7, 6, 5, 9, 3, 2, 1, 0, 4}, 
            {9, 8, 7, 6, 5, 4, 3, 2, 1, 0}
        };
        // The permutation table
        int[,] Permutacion = new int[,]
        {
            {0, 1, 2, 3, 4, 5, 6, 7, 8, 9}, 
            {1, 5, 7, 6, 2, 8, 3, 0, 9, 4}, 
            {5, 8, 0, 3, 7, 9, 6, 1, 4, 2}, 
            {8, 9, 1, 6, 0, 4, 3, 5, 2, 7}, 
            {9, 4, 5, 3, 1, 2, 6, 8, 7, 0}, 
            {4, 2, 8, 6, 5, 7, 3, 9, 0, 1}, 
            {2, 7, 9, 3, 8, 0, 6, 4, 1, 5}, 
            {7, 0, 4, 6, 9, 1, 3, 2, 5, 8}
        };
        // The inverse table
        int[] Inverso = { 0, 4, 3, 2, 1, 5, 6, 7, 8, 9 };
        #endregion
        #region Metodos
        //Invertir El Numero
        private string CadenaAVectorDeEnterosInverso(string Numero)
        {
            string numeroinvertido = "";
            for (int i = Numero.Length - 1; i >= 0; i--)
            {
                numeroinvertido = numeroinvertido + Numero[i];
            }
            return numeroinvertido;
        }
        //Generar Verhoeff
        public string GenerarVerhoeff(string Numero)
        {
            int c = 0;
            string numeroinvertido = CadenaAVectorDeEnterosInverso(Numero);
            for (int i = 0; i < numeroinvertido.Length; i++)
            {
                c = Multiplicacion[c, Permutacion[((i + 1) % 8), Convert.ToInt32(numeroinvertido[i].ToString())]];
            }
            return Inverso[c].ToString();
        }
        #endregion
    }
}