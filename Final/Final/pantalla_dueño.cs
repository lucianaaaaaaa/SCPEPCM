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
    public partial class pantalla_dueño : Form
    {
        public pantalla_dueño()
        {
            InitializeComponent();
        }

        private void btn_añadir_producto_Click(object sender, EventArgs e)
        {
            this.Hide();
            añadir_producto añadir_Producto = new añadir_producto();
            añadir_Producto.Show();
        }

        private void btn_despedir_empleado_Click(object sender, EventArgs e)
        {
            this.Hide();
            despedir_empleado despedir_Empleado = new despedir_empleado();
            despedir_Empleado.Show();
        }

        private void btn_añadir_empleado_Click(object sender, EventArgs e)
        {
            this.Hide();
            añadir_empleado añadir_Empleado = new añadir_empleado();
            añadir_Empleado.Show();
        }

        private void btn_ver_inventario_Click(object sender, EventArgs e)
        {
            this.Hide();
            ver_inventario ver_Inventario = new ver_inventario();
            ver_Inventario.Show();
        }
    }
}
