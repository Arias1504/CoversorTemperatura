using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Temperatura;

namespace Conversor_Temperatura
{
    public partial class Form1 : Form
    {
        private void Mensaje(String texto)
        {
            MessageBox.Show(texto, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtTemperatura.Text = string.Empty;
            this.lblValor.Text = string.Empty;
            this.boxTemp.Text = string.Empty;
            this.boxTemp2.Text = string.Empty;
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            float fltTemp;
            int intTemp1, intTemp2;
            try
            {
                //Captura de imformacion de entrada 
                fltTemp = Convert.ToSingle(this.txtTemperatura.Text);
                intTemp1 = boxTemp.SelectedIndex;
                intTemp2 = boxTemp2.SelectedIndex;

                //Instanciar la clase
                clsTemperatura of = new clsTemperatura();

                //Envio informacion a la clase 
                of.vrTemperatura = fltTemp;
                of.vrTemp1 = intTemp1;
                of.vrTemp2 = intTemp2;

                // Invocación del metodo y tratamiento del error
                if (!of.Convertir())
                {
                    Mensaje(of.Error);
                    of = null; //Opcional
                    return;
                }

                //Mostrar informacion
                this.lblValor.Text = of.vrSalida.ToString();
            }
            catch (Exception ex)
            {

                Mensaje(ex.Message);
            }
        }
    }
}
