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
    public partial class pantalla_empleado : Form
    {
        public pantalla_empleado()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_generar_comprobante_Click(object sender, EventArgs e)
        {
            this.Hide();
            generar_comprobante generar_Comprobante = new generar_comprobante();    
            generar_Comprobante.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult mensaje = MessageBox.Show("¿Desea cerrar sesion?", "", MessageBoxButtons.OKCancel);
            if (mensaje == DialogResult.OK)
            {
                this.Hide();
                Inicio_Sesion inicio_Sesion = new Inicio_Sesion();
                inicio_Sesion.Show();

            }
        }
    }
}
