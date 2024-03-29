﻿using Dal;
using Ent;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bss
{
    public class AperturaDeCajaBss
    {
        #region Objects
        AperturaDeCajaDal objetoAperturaDeCaja = new AperturaDeCajaDal();
        #endregion
        #region Methods
        public int add(AperturaDeCajaEnt aperturaDeCaja)
        {
            return objetoAperturaDeCaja.add(aperturaDeCaja);
        }
        public void close(AperturaDeCajaEnt aperturaDeCaja)
        {
            objetoAperturaDeCaja.close(aperturaDeCaja);
        }
        public int exist(AperturaDeCajaEnt aperturaDeCaja)
        {
            return objetoAperturaDeCaja.exist(aperturaDeCaja);
        }
        public int exists(AperturaDeCajaEnt aperturaDeCaja)
        {
            return objetoAperturaDeCaja.exists(aperturaDeCaja);
        }
        public DataTable get(AperturaDeCajaEnt aperturaDeCaja)
        {
            return objetoAperturaDeCaja.get(aperturaDeCaja);
        }
        public int getId(AperturaDeCajaEnt aperturaDeCaja)
        {
            return objetoAperturaDeCaja.getId(aperturaDeCaja);
        }
        #endregion
    }
}