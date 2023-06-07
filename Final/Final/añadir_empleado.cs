using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Final
{
    public partial class añadir_empleado : Form
    {

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "ExAWzOGUGQ37zf9X2381ZGbRYxaxrVqlgzPpsAZZ",
            BasePath = "https://scpepcm-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        public añadir_empleado()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            pantalla_dueño pantalla = new pantalla_dueño();
            pantalla.Show();
        }

        private void bttn_atrás_Click(object sender, EventArgs e)
        {
            pantalla_dueño pt = new pantalla_dueño();
            pt.Show();
            this.Hide();
        }

        private void añadir_empleado_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                txt_fecha_ingreso.Enabled = false;
            }
            else
            {
                txt_fecha_ingreso.Enabled = true;
            }
        }

        private async void btn_registrar_Click(object sender, EventArgs e)
        {
            if(txt_nombres.Text == "" || txt_CI.Text == "" || txt_confirmar_contraseña.Text == "" ||
                txt_fecha_nacimiento.Text == "" || (txt_fecha_ingreso.Text == "" && txt_fecha_ingreso.Enabled) ||
                txt_nacionalidad.Text == "" || txt_nombre_usuario.Text == "")
            {
                MessageBox.Show("Todos los campos deben estar llenos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(txt_confirmar_contraseña.Text != txt_contraseña.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string fechaEntrada;
                    if(checkBox1.Checked)
                    {
                        fechaEntrada = DateTime.Now.Date.ToString(); //Revisar si ésto está bien
                    }
                    else
                    {
                        fechaEntrada = txt_fecha_nacimiento.Text;
                    }
                    var datalayer = new Empleados
                    {
                        Usuario = txt_nombre_usuario.Text,
                        CI = txt_CI.Text,
                        Password = txt_contraseña.Text,
                        FNac = txt_fecha_nacimiento.Text,
                        FEntrada = fechaEntrada,
                        Nombre = txt_nombres.Text

                    };
                    SetResponse resp = await client.SetAsync("Empleados/" + txt_nombre_usuario.Text, datalayer);
                    MessageBox.Show("El usuario " + txt_nombre_usuario.Text + 
                        " se agregó correctamente", "Nuevo empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarTodo();

                }
            }
        }
        private void limpiarTodo()
        {
            txt_CI.Text = "";
            txt_confirmar_contraseña.Text = "";
            txt_contraseña.Text = "";
            txt_fecha_ingreso.Text = "";
            txt_fecha_nacimiento.Text = "";
            txt_nacionalidad.Text = "";
            txt_nombres.Text = "";
            txt_nombre_usuario.Text = "";
        }
    }
}
