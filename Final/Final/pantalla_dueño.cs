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

        private void btn_salir_Click(object sender, EventArgs e)
        {
            DialogResult mensaje = MessageBox.Show("¿Desea cerrar sesion?", "", MessageBoxButtons.OKCancel);
            if (mensaje == DialogResult.OK)
            {
                this.Hide();
                Inicio_Sesion inicio_Sesion = new Inicio_Sesion();
                inicio_Sesion.Show();

            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Datos_modificar_producto datos_Modificar_Producto = new Datos_modificar_producto();
            this.Hide();
            datos_Modificar_Producto.Show();
        }
    }
}
