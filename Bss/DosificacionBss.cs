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
    public class DosificacionBss
    {
        #region Objetos
        DosificacionDal dosificacion = new DosificacionDal();
        #endregion
        #region Metodos
        public int authenticate(DosificacionEnt dosificacionX)
        {
            return dosificacion.authenticate(dosificacionX);
        }
        public int checkEmissionDeadline(DosificacionEnt dosificacionX)
        {
            return dosificacion.checkEmissionDeadline(dosificacionX);
        }
        public int exists(DosificacionEnt dosificacionX)
        {
            return dosificacion.exists(dosificacionX);
        }
        public DataTable findAll(DosificacionEnt dosificacionX)
        {
            return dosificacion.findAll(dosificacionX);
        }
        public int insert(DosificacionEnt dosificacionX)
        {
            return dosificacion.insert(dosificacionX);
        }
        public DataTable search(DosificacionEnt dosificacionX)
        {
            return dosificacion.search(dosificacionX);
        }
        public DataTable searchAll(DosificacionEnt dosificacionX)
        {
            return dosificacion.searchAll(dosificacionX);
        }
        public DataTable select(DosificacionEnt dosificacionX)
        {
            return dosificacion.select(dosificacionX);
        }
        public void update(DosificacionEnt dosificacionX)
        {
            dosificacion.update(dosificacionX);
        }
        public void updateStatus(DosificacionEnt dosificacionX)
        {
            dosificacion.updateStatus(dosificacionX);
        }
        #endregion
    }
}