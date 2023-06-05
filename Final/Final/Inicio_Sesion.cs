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
    public partial class Inicio_Sesion : Form
    {
        public Inicio_Sesion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            pantalla_dueño pantalla_Dueño = new pantalla_dueño();
            pantalla_Dueño.Show();
        }
    }
}
