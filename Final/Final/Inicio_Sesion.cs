using FireSharp.Config;
using FireSharp.Interfaces;
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
using FireSharp.Response;
using FireSharp.Interfaces;
using System.Xml.Linq;

namespace Final
{
    //eljefe@gmail.com
    //tengoplata123
    public partial class Inicio_Sesion : Form
    {
        //comentario
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "ExAWzOGUGQ37zf9X2381ZGbRYxaxrVqlgzPpsAZZ",
            BasePath = "https://scpepcm-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
       
        public Inicio_Sesion()
        {
            InitializeComponent();
            //label1.Text = DateTime.Now.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btn_ingresar_Click(object sender, EventArgs e)
        {
            if(txt_contraseña.Text == "" || txt_usuario.Text == "")
            {
                MessageBox.Show("Debes llenar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(txt_usuario.Text == Intermediario.userDueño && Intermediario.passDueño == txt_contraseña.Text)
                {
                    this.Hide();
                    Intermediario.soyElDueño = true;
                    pantalla_dueño pantalla_Dueño = new pantalla_dueño();
                    pantalla_Dueño.Show();
                }
                else
                {
                    //Validar si el empleado existe
                    FirebaseResponse responseEmpleado = await client.GetAsync("Empleados/" + txt_usuario.Text.ToString());
                    
                    Empleados empleado = responseEmpleado.ResultAs<Empleados>();
                    if(empleado == null)
                    {
                        MessageBox.Show("El usuario no está registrado, inténtelo nuevamente",
                            "Quién eres?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if(empleado.Password != txt_contraseña.Text)
                        {
                            MessageBox.Show("Contraseña incorrecta",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            pantalla_empleado pantallaEmpleado = new pantalla_empleado();
                            this.Hide();
                            pantallaEmpleado.Show();
                        }
                    }
                    
                }

                
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void Inicio_Sesion_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            if (client != null)
            {
                //Conectado
            }
            
        }

        private void SinCaracteresRaros(object sender, KeyPressEventArgs e)
        {

            if (char.IsLetter(e.KeyChar) || char.IsNumber(e.KeyChar) ||  e.KeyChar == (char)Keys.Back)
            {
                txt_usuario.BackColor = Color.White;
            }
            else
            {
                e.Handled = true;
                txt_usuario.BackColor = Color.Red;
            }
        }

        private void txt_contraseña_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void mostrarContra(object sender, EventArgs e)
        {
            txt_contraseña.UseSystemPasswordChar = false;
        }

        private void ocultarContra(object sender, EventArgs e)
        {
            txt_contraseña.UseSystemPasswordChar = true;
        }

        /*private async void button1_Click(object sender, EventArgs e)
        {
            var datalayerEmpleado = new Empleados
            {
                usuario = "juanperro",
                CI = "100230",
                Password = "dcopn",
                FNac = "123",
                FEntrada = "1000",
                Nombre = "Sorocum"
            };
            SetResponse resp = await client.SetAsync("Empleados/juanperro", datalayerEmpleado);
            Empleados result = resp.ResultAs<Empleados>();
        }*/
    }
}
