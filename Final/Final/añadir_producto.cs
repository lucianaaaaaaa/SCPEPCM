using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
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
        List<Productos> lista_productos = new List<Productos>();

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "ExAWzOGUGQ37zf9X2381ZGbRYxaxrVqlgzPpsAZZ",
            BasePath = "https://scpepcm-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
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

        private async void llenar_dgv_productos()
        {
            lista_productos.Clear();
            FirebaseResponse responseAlmacén = await client.GetAsync("Reserva/Productos");
            Almacén reserva = responseAlmacén.ResultAs<Almacén>();

            for (int i = 0; i < reserva.Productos; i++)
            {
                FirebaseResponse responseProducto = await client.GetAsync("Productos/" + (1000 + i).ToString());
                Productos producto = responseProducto.ResultAs<Productos>();
                if (producto.Reserva >= 0)
                {
                    lista_productos.Add(producto);
                }
            }
            dgv_productos.DataSource = null;
            dgv_productos.DataSource = lista_productos;
        }

        private void añadir_producto_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            llenar_dgv_productos();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            llenar_dgv_productos();
        }

        private void bttn_atrás_Click(object sender, EventArgs e)
        {
            pantalla_dueño pd = new pantalla_dueño();
            pd.Show();
            this.Hide();
        }
    }
}
