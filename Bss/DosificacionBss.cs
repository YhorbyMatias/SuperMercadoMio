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
        DosificacionDal objetoDosificacion = new DosificacionDal();
        #endregion
        #region Metodos
        public int add(DosificacionEnt dosificacion)
        {
            return objetoDosificacion.add(dosificacion);
        }
        public int authenticate(DosificacionEnt dosificacion)
        {
            return objetoDosificacion.authenticate(dosificacion);
        }
        public int exists(DosificacionEnt dosificacion)
        {
            return objetoDosificacion.exists(dosificacion);
        }
        public DataTable findAll()
        {
            return objetoDosificacion.findAll();
        }
        public int getId(DosificacionEnt dosificacion)
        {
            return objetoDosificacion.getId(dosificacion);
        }
        public int getRemainingDays(DosificacionEnt dosificacion)
        {
            return objetoDosificacion.getRemainingDays(dosificacion);
        }
        public DataTable search(DosificacionEnt dosificacion)
        {
            return objetoDosificacion.search(dosificacion);
        }
        public DataTable searchAll(DosificacionEnt dosificacion)
        {
            return objetoDosificacion.searchAll(dosificacion);
        }
        public DataTable select(DosificacionEnt dosificacion)
        {
            return objetoDosificacion.select(dosificacion);
        }
        public void update(DosificacionEnt dosificacion)
        {
            objetoDosificacion.update(dosificacion);
        }
        public void updateStatus(DosificacionEnt dosificacion)
        {
            objetoDosificacion.updateEstado(dosificacion);
        }
        #endregion
    }
}