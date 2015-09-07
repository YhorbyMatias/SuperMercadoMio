using Ent;
using Microsoft.PointOfService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bss
{
    public class ImpresionBss
    {
        #region Objetos
        private PosPrinter posPrinter = null;
        #endregion
        #region Metodos
        public void openConnection()
        {
            string logicalName = "PosPrinter2";
            PosExplorer posExplorer = new PosExplorer();
            DeviceInfo deviceInfo = null;
            try
            {
                deviceInfo = posExplorer.GetDevice(DeviceType.PosPrinter, logicalName);
            }
            catch (Exception exceptionX)
            {
                throw exceptionX;
            }
            try
            {
                posPrinter = (PosPrinter)posExplorer.CreateInstance(deviceInfo);
            }
            catch (Exception exceptionX)
            {
                throw exceptionX;
            }
            try
            {
                posPrinter.Open();
                posPrinter.PowerNotify = PowerNotification.Enabled;
            }
            catch (Exception exceptionX)
            {
                throw exceptionX;
            }
            try
            {
                posPrinter.Claim(1000);
            }
            catch (PosControlException posControlExceptionX)
            {
                throw posControlExceptionX;
            }
            try
            {
                posPrinter.DeviceEnabled = true;
            }
            catch (PosControlException posControlExceptionX)
            {
                throw posControlExceptionX;
            }
            try
            {
                posPrinter.RecLetterQuality = false;
                posPrinter.MapMode = MapMode.Metric;
                SesionEnt.posPrinter = posPrinter;
            }
            catch (PosControlException posControlExceptionX)
            {
                throw posControlExceptionX;
            }
        }
        public void closeConnection()
        {
            if (posPrinter != null)
            {
                try
                {
                    posPrinter.DeviceEnabled = false;
                    posPrinter.Release();
                }
                catch (PosControlException posControlExceptionX)
                {
                    throw posControlExceptionX;
                }
                finally
                {
                    if (posPrinter.State != ControlState.Closed)
                    {
                        posPrinter.Close();
                        SesionEnt.posPrinter = posPrinter;
                    }
                }
            }
        }
        #endregion
    }
}