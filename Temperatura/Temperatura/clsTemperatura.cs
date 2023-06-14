using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura
{
    public class clsTemperatura
    {
        #region "Atributos"
        private float fltTemperatura;
        private float fltTempSalida;
        private int intVrTemp1;
        private int intVrTemp2;
        private string strError;

        #endregion

        #region "Constructor"
        public clsTemperatura()
        {
            fltTemperatura = 0;
            fltTempSalida = 0;
            intVrTemp1 = 0;
            intVrTemp2 = 0;
            strError = string.Empty;
        }
        #endregion

        #region "Propiedades"
        //entrada
        public float vrTemperatura
        {
            set { fltTemperatura = value; }
        }

        public int vrTemp1
        {
            set { intVrTemp1 = value; }
        }

        public int vrTemp2
        {
            set { intVrTemp2 = value; }
        }

        //salida

        public float vrSalida
        {
            get { return fltTempSalida; }
        }
        public string Error
        {
            get { return strError; }
        }
        #endregion

        #region "Metodos privados"
        public bool validar()
        {
            if (fltTemperatura == null)
            {
                strError = "Error, valor no valido";
                return false;
            }
            return true;
        }
        #endregion

        #region "Metodos publicos"
        public bool Convertir()
        {

            try
            {
                if (!validar())
                    return false;

                switch (intVrTemp1)
                {
                    case 0:
                        if (intVrTemp2 == 0)
                        {
                            fltTempSalida = fltTemperatura;
                        }
                        if (intVrTemp2 == 1)
                        {
                            fltTempSalida = ((float)(fltTemperatura * 1.8 + 32));
                        }
                        if (intVrTemp2 == 2)
                        {
                            fltTempSalida = (float)(fltTemperatura + 273.15);
                        }
                        if (intVrTemp2 == 3)
                        {
                            fltTempSalida = (float)((fltTemperatura + 273.15) * 9 / 5);
                        }
                        break;
                    case 1:
                        if (intVrTemp2 == 0)
                        {
                            fltTempSalida = (float)((fltTemperatura - 32) / 1.8);
                        }
                        if (intVrTemp2 == 1)
                        {
                            fltTempSalida = fltTemperatura;
                        }
                        if (intVrTemp2 == 2)
                        {
                            fltTempSalida = (float)((fltTemperatura - 32) * 5 / 9 + 273.15);
                        }
                        if (intVrTemp2 == 3)
                        {
                            fltTempSalida = (float)(fltTemperatura + 459.67);
                        }
                        break;
                    case 2:
                        if (intVrTemp2 == 0)
                        {
                            fltTempSalida = (float)(fltTemperatura - 273.15);
                        }
                        if (intVrTemp2 == 1)
                        {
                            fltTempSalida = (float)(1.8 * (fltTemperatura - 273.15) + 32);
                        }
                        if (intVrTemp2 == 2)
                        {
                            fltTempSalida = fltTemperatura;
                        }
                        if (intVrTemp2 == 3)
                        {
                            fltTempSalida = (float)(fltTemperatura * 1.8);
                        }
                        break;
                    case 3:
                        if (intVrTemp2 == 0)
                        {
                            fltTempSalida = (float)(fltTemperatura - 491.67) * 5 / 9;
                        }
                        if (intVrTemp2 == 1)
                        {
                            fltTempSalida = (float)(fltTemperatura - 459.67);
                        }
                        if (intVrTemp2 == 2)
                        {
                            fltTempSalida = (float)(fltTemperatura * 5 / 9);
                        }
                        if (intVrTemp2 == 3)
                        {
                            fltTempSalida = fltTemperatura;
                        }
                        break;
                    default:
                        break;
                }

                return true;
            }
            catch (Exception ex )
            {

                strError = ex.Message;
                return false;
            }
            return false;
        }
        #endregion

    }
}
