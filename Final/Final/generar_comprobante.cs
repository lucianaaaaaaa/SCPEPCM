using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class generar_comprobante : Form
    {
        public generar_comprobante()
        {
            InitializeComponent();
            //MessageBox.Show(Intermediario.costoTotal.ToString());
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Intermediario.canastas;
            if(Intermediario.nombreCliente == "")
            {
                lbl_nombre.Text = "Sin nombre";
            }
            else
            {
                lbl_nombre.Text = Intermediario.nombreCliente;
            }
            if(Intermediario.nitCliente == "")
            {
                lbl_NIT.Text = "---";
            }
            else
            {
                lbl_NIT.Text = Intermediario.nitCliente;
            }
            if(Intermediario.costoTotal > 2500)
            {
                lbl_descuento.Text = (Intermediario.costoTotal * 0.2).ToString();
                lbl_total_pagar.Text = (Intermediario.costoTotal * .8).ToString();
            }
            else if(Intermediario.costoTotal > 700)
            {
                lbl_descuento.Text = (Intermediario.costoTotal * 0.05).ToString();
                lbl_total_pagar.Text = (Intermediario.costoTotal * .95).ToString();
            }
            else
            {
                lbl_descuento.Text = "0";
                lbl_total_pagar.Text = (Intermediario.costoTotal).ToString();
                //lbl_total_pagar.Text = "11";
            }
        }

        private void btn_registro_compra_Click(object sender, EventArgs e)
        {
            this.Hide();
            pantalla_empleado pantalla_Empleado = new pantalla_empleado();
            pantalla_Empleado.Show();
            Intermediario.costoTotal = 0;
        }
    }
}
