using Ent;
using Microsoft.PointOfService;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bss
{
    public class ImpresoraBss
    {
        #region Objetos
        private PosPrinter posPrinter = null;
        private LiteralBss literal = new LiteralBss();
        #endregion
        #region Metodos
        public void openConnection()
        {
            SesionEnt.printerEnabled = false;
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
            if (deviceInfo != null)
            {
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
                    SesionEnt.printerEnabled = true;
                }
                catch (PosControlException posControlExceptionX)
                {
                    throw posControlExceptionX;
                }
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
        public string formatoDeImpresionDeFactura(DataTable invoice, DataTable invoiceLines, int recLinesToPaperCut)
        {
            string formatoFinal = "\u001b|cA" + "SUPER MERCADO MIO" + "\n"
                + "\u001b|cA" + "de PABLO CESAR GUTIERREZ" + "\n"
                + "\u001b|cA" + "Sucursal N° 0" + "\n"
                + "\u001b|cA" + "CALLE MENDEZ ESQUINA INGAVI" + "\n"
                + "\u001b|cA" + "Tarija - Bolivia"
                + "\u001b|300uF"
                + "\u001b|cA" + "\u001b|uC                                  " + "\n\u001b|N"
                + "\u001b|300uF"
                + "\u001b|cA" + "SFC-1" + "\n"
                + "\u001b|cA" + "\u001b|bC" + "FACTURA" + "\n\u001b|N"
                + "\u001b|lA" + "   NIT: 5006643010 " + espaciadoDeNumeroDeFactura(invoice.Rows[0]["Numero_De_Factura"].ToString()) + "   \n"
                + "\u001b|lA" + "   N° Autorización: " + invoice.Rows[0]["Numero_De_Autorizacion"].ToString()
                + "\u001b|300uF"
                + "\u001b|cA" + "\u001b|uC                                  " + "\n\u001b|N"
                + "\u001b|300uF"
                + "\u001b|lA" + "Fecha y Hora: " + Convert.ToDateTime(invoice.Rows[0]["Fecha"]).ToShortDateString() + " "
                + invoice.Rows[0]["Hora"].ToString() + "\n"
                + "\u001b|lA" + "CI/NIT: " + invoice.Rows[0]["Ci_O_Nit"].ToString() + "\n"
                + "\u001b|lA" + "Señor(es): " + invoice.Rows[0]["Cliente"].ToString()
                + "\u001b|300uF"
                + "\u001b|uC                                        "
                + "\u001b|100uF"
                + "\u001b|uC                                        " + "\n\u001b|N"
                + "\u001b|lA" + "Artículo                  Cant.  Importe"
                + "\u001b|100uF"
                + "\u001b|uC" + "                                        " + "\n\u001b|N"
                + obtenerCadenaDeDetalleDeFactura(invoiceLines)
                + "\u001b|100uF"
                + "\u001b|uC                                        " + "\n\u001b|N"
                + "\u001b|bC" + espaciadoDeMontoTotal(Convert.ToDecimal(invoice.Rows[0]["Monto"]).ToString("0.00")) + "\n\u001b|N"
                + "\u001b|lA" + espaciadoDeMontoPagado(Convert.ToDecimal(invoice.Rows[0]["Monto_Pagado"]).ToString("0.00")) + "\n"
                + "\u001b|lA" + espaciadoDeCambio(Convert.ToDecimal(invoice.Rows[0]["Cambio"]).ToString("0.00")) + "\n"
                + "\u001b|lA" + "Son: " + literal.convertirALiteral(invoice.Rows[0]["Precio_Total"].ToString()) + "\n"
                + "\u001b|bC" + "Código de Control: " + invoice.Rows[0]["Codigo_De_Control"].ToString() + "\n\u001b|N"
                + "\u001b|lA" + "Fecha Vencimiento: " + Convert.ToDateTime(invoice.Rows[0]["Fecha_Vencimiento"]).ToShortDateString() + "\n"
                + "\u001b|lA" + espaciadoDeUsuarioYCaja(invoice.Rows[0]["Usuario"].ToString(), invoice.Rows[0]["Numero_Caja"].ToString())
                + "\u001b|100uF"
                + "\u001b|uC                                        "
                + "\u001b|100uF"
                + "\u001b|uC                                        " + "\n\u001b|N"
                + "\u001b|200uF"
                + "\u001b|cA" + "La reproducción total o parcial y/o el" + "\n"
                + "\u001b|cA" + "uso no autorizado de esta Nota Fiscal" + "\n"
                + "\u001b|cA" + "constituye un delito a ser sancionado" + "\n"
                + "\u001b|cA" + "conforme a ley" + "\n" + "\n" + "GRACIAS POR SU COMPRA!!!"
                + "\u001b|" + recLinesToPaperCut + "lF";
            return formatoFinal;
        }
        private string espaciadoDeNumeroDeFactura(string numeroDeFacturaX)
        {
            string resultado = "N° Factura: " + numeroDeFacturaX;
            int longitud = 18 - resultado.Length;
            for (int espacios = 0; espacios < longitud; espacios++)
            {
                resultado = " " + resultado;
            }
            return resultado;
        }
        private string espaciadoDeDetalleDeFactura(string productoX, string cantidadX, string importeX, bool Ultimo)
        {
            string lineaDeDetalleFinal = "";
            string lineaDeDetalle = "";
            string restante = "";
            string lineasDeDetalleAdicionales = "";
            if (productoX.Length <= 24)
            {
                if (productoX.Length == 24)
                {
                    lineaDeDetalle = productoX;
                }
                else
                {
                    lineaDeDetalle = productoX;
                    int longitud = 24 - lineaDeDetalle.Length;
                    for (int espacios = 0; espacios < longitud; espacios++)
                    {
                        lineaDeDetalle = lineaDeDetalle + " ";
                    }
                }
            }
            else
            {
                lineaDeDetalle = productoX.Substring(0, 24);
                restante = productoX.Substring(24);
                while (restante.Length >= 24)
                {
                    lineasDeDetalleAdicionales = lineasDeDetalleAdicionales + "\u001b|lA" + restante.Substring(0, 24) + "\n";
                    restante = restante.Substring(24);
                }
                if (restante != "")
                {
                    lineasDeDetalleAdicionales = lineasDeDetalleAdicionales + "\u001b|lA" + restante + "\n";
                }
            }
            lineaDeDetalle = lineaDeDetalle + " ";
            int longitudcantidad = 6 - cantidadX.Length;
            for (int espacios = 0; espacios < longitudcantidad; espacios++)
            {
                lineaDeDetalle = lineaDeDetalle + " ";
            }
            lineaDeDetalle = lineaDeDetalle + cantidadX.ToString() + " ";
            int longitudimporte = 8 - importeX.Length;
            for (int espacios = 0; espacios < longitudimporte; espacios++)
            {
                lineaDeDetalle = lineaDeDetalle + " ";
            }
            lineaDeDetalle = lineaDeDetalle + importeX.ToString();
            if (Ultimo == true)
            {
                if (lineasDeDetalleAdicionales != "")
                {
                    lineaDeDetalleFinal = "\u001b|lA" + lineaDeDetalle + "\n"
                        + lineasDeDetalleAdicionales.Substring(0, lineasDeDetalleAdicionales.Length - 1);
                }
                else
                {
                    lineaDeDetalleFinal = "\u001b|lA" + lineaDeDetalle;
                }
            }
            else
            {
                lineaDeDetalleFinal = "\u001b|lA" + lineaDeDetalle + "\n";
                if (lineasDeDetalleAdicionales != "")
                {
                    lineaDeDetalleFinal = lineaDeDetalleFinal + lineasDeDetalleAdicionales;
                }
            }
            return lineaDeDetalleFinal;
        }
        private string obtenerCadenaDeDetalleDeFactura(DataTable dataTableDetalleDeFacturaX)
        {
            string detalleDeFactura = "";
            bool ultimo = false;
            for (int filas = 0; filas < dataTableDetalleDeFacturaX.Rows.Count; filas++)
            {
                if (filas == dataTableDetalleDeFacturaX.Rows.Count - 1)
                {
                    ultimo = true;
                }
                detalleDeFactura = detalleDeFactura + espaciadoDeDetalleDeFactura(dataTableDetalleDeFacturaX.Rows[filas]["Concepto"].ToString(),
                    Convert.ToDecimal(dataTableDetalleDeFacturaX.Rows[filas]["Cantidad"]).ToString("0.00"),
                    Convert.ToDecimal(dataTableDetalleDeFacturaX.Rows[filas]["Precio_Total"]).ToString("0.00"), ultimo);
            }
            return detalleDeFactura;
        }
        private string espaciadoDeMontoTotal(string montoTotalX)
        {
            string resultado = "Total: " + montoTotalX;
            int longitud = 40 - resultado.Length;
            for (int espacios = 0; espacios < longitud; espacios++)
            {
                resultado = " " + resultado;
            }
            return resultado;
        }
        private string espaciadoDeMontoPagado(string montoPagadoX)
        {
            string resultado = "Pagado: " + montoPagadoX;
            int longitud = 40 - resultado.Length;
            for (int espacios = 0; espacios < longitud; espacios++)
            {
                resultado = " " + resultado;
            }
            return resultado;
        }
        private string espaciadoDeCambio(string cambioX)
        {
            string resultado = "Cambio: " + cambioX;
            int longitud = 40 - resultado.Length;
            for (int espacios = 0; espacios < longitud; espacios++)
            {
                resultado = " " + resultado;
            }
            return resultado;
        }
        private string espaciadoDeUsuarioYCaja(string usuarioX, string cajaX)
        {
            string usuario = "Usuario: " + usuarioX;
            string caja = "Caja: " + cajaX;
            int longitud = 40 - (usuario.Length + caja.Length);
            for (int espacios = 0; espacios < longitud; espacios++)
            {
                caja = " " + caja;
            }
            usuario = usuario + caja;
            return usuario;
        }
        #endregion
    }
}