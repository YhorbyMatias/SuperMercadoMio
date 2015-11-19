using Microsoft.PointOfService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent
{
    public class SesionEnt
    {
        public static int idUsuario;
        public static string nombreDeUsuario;
        public static string nombreDeEquipo;
        public static int idCaja;
        public static bool activeDosificacion;
        public static PosPrinter posPrinter = null;
        public static bool printerEnabled;
    }
}