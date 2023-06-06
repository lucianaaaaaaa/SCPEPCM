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
    public partial class añadir_producto : Form
    {
        public añadir_producto()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            pantalla_dueño pantalla = new pantalla_dueño();
            pantalla.Show();
        }

        private void linklbl_agregar_producto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            datos_agregar_producto datos_producto = new datos_agregar_producto();
            datos_producto.Show();
        }
    }
}
