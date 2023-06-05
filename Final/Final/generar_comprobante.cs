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
        }

        private void btn_registro_compra_Click(object sender, EventArgs e)
        {
            this.Hide();
            pantalla_empleado pantalla_Empleado = new pantalla_empleado();
            pantalla_Empleado.Show();
        }
    }
}
