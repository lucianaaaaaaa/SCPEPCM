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
    public partial class despedir_empleado : Form
    {
        List <string> usuarios = new List <string> ();
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "ExAWzOGUGQ37zf9X2381ZGbRYxaxrVqlgzPpsAZZ",
            BasePath = "https://scpepcm-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        public despedir_empleado()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            pantalla_dueño pantalla = new pantalla_dueño();
            pantalla.Show();
        }

        private void bttn_atrás_Click(object sender, EventArgs e)
        {
            pantalla_dueño pd = new pantalla_dueño();
            pd.Show();
            this.Hide();
        }

        private void despedir_empleado_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            llenarUsuarios();
        }

        private async void llenarUsuarios()
        {
            usuarios.Clear();
            FirebaseResponse respuesta = await client.GetAsync("Empleados");
            dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject(respuesta.Body);
            foreach (var empleado in data)
            {
                usuarios.Add(empleado.Name);
            }
            comboBox1.DataSource = null;
            comboBox1.DataSource = usuarios;
        }

        private async void btn_eliminar_empleado_Click(object sender, EventArgs e)
        {
            if(txt_nombre_aplicacion.Text != "SCPEPCM")
            {
                MessageBox.Show("EL NOMBRE NO COINCIDE", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                FirebaseResponse response = await client.DeleteAsync("Empleados/" + comboBox1.SelectedText);
                MessageBox.Show("EL acceso del usuario " + comboBox1.SelectedText + 
                    " ha sido revocado", "Empleado despedido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                llenarUsuarios();
                txt_nombre_aplicacion.Text = "";
            }
        }
    }
}
