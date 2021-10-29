using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio_Integrador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButtonCamisa_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCamisa.Checked == true)
            {
                checkBoxBermuda.Enabled = false;
            }
            else
            {
                checkBoxBermuda.Enabled = true;
            }
        }

        private void radioButtonPantalon_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPantalon.Checked == true)
            {
                checkBoxMangaCorta.Enabled = false;
            }
            else
            {
                checkBoxMangaCorta.Enabled = true;
            }
        }

        private void buttonPrecioFinal_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonCamisa.Checked == true)
                {
                    Camisa camisa = new Camisa(checkBoxMangaCorta.Checked);
                    camisa.Precio = Convert.ToDouble(txtPrecio.Text);
                    camisa.Premium = radioButtonPremium.Checked;
                    camisa.Standard = radioButtonStandard.Checked;
                    camisa.Cantidad = Int32.Parse(txtCalidad.Text);
                    camisa.PrecioFinal();
                    camisa.PrecioFinalCamisa();
                    MessageBox.Show("Precio Final: $" + camisa.PrecioFinalCamisa(), "Gracias Por su Compra.", MessageBoxButtons.OK);
                }

                if (radioButtonPantalon.Checked == true)
                {
                    Pantalon pantalon = new Pantalon(checkBoxBermuda.Checked);
                        pantalon.Precio = Convert.ToDouble(txtPrecio.Text);
                        pantalon.Premium = radioButtonPremium.Checked;
                        pantalon.Standard = radioButtonStandard.Checked;
                        pantalon.Cantidad = Int32.Parse(txtCalidad.Text);
                        pantalon.PrecioFinal();
                        pantalon.PrecioFinalPantalon();
                        MessageBox.Show("Precio Final: $" + pantalon.PrecioFinalPantalon(), "Gracias Por su Compra.", MessageBoxButtons.OK);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error en el formato ingresado. Descripción" + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
