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
    public partial class Datos_modificar_producto : Form
    {
        List <string> productos = new List <string> ();
        Productos productoSeleccionado;
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "ExAWzOGUGQ37zf9X2381ZGbRYxaxrVqlgzPpsAZZ",
            BasePath = "https://scpepcm-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        public Datos_modificar_producto()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            //llenarLista();
            
        }
        public async void llenarLista()
        {
            productos.Clear();
            FirebaseResponse responseAlmacén = await client.GetAsync("Reserva/Productos");
            Almacén reserva = responseAlmacén.ResultAs<Almacén>();
            //int tall = Int32.Parse(responseAlmacén.ToString());

            for (int i = 0; i < reserva.Productos; i++)
            {
                FirebaseResponse responseProducto = await client.GetAsync("Productos/" + (1000 + i).ToString());
                Productos producto = responseProducto.ResultAs<Productos>();
                if (producto.Reserva != 0)
                {
                    productos.Add(producto.Nombre);
                }
            }
            comboBox1.DataSource = null;
            comboBox1.DataSource = productos;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void CuandoSeleccione(object sender, EventArgs e)
        {
            FirebaseResponse responseAlmacén = await client.GetAsync("Reserva/Productos");
            Almacén reserva = responseAlmacén.ResultAs<Almacén>();
            for (int i = 0; i < reserva.Productos; i++)
            {
                FirebaseResponse responseProducto = await client.GetAsync("Productos/" + (1000 + i).ToString());
                Productos producto = responseProducto.ResultAs<Productos>();
                if (producto.Nombre == comboBox1.Text)
                {
                    productoSeleccionado = producto;
                    txt_cantidad_producto.Text = producto.Reserva.ToString();
                    txt_costo_producto.Text = producto.Costo.ToString();
                    break;
                }
            }
            txt_descuento.Text = "0";
        }

        private async void btn_agregar_producto_Click(object sender, EventArgs e)
        {
            if(Convert.ToDouble(txt_descuento.Text) > 100D)
            {
                MessageBox.Show("Estarías regalando dinero", "Falla crítica en tu cerebro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                productoSeleccionado.Reserva = Int32.Parse(txt_cantidad_producto.Text);
                productoSeleccionado.Costo = Convert.ToDouble(txt_costo_producto.Text);
                productoSeleccionado.Costo = Convert.ToDouble(productoSeleccionado.Costo) * (1D - Convert.ToDouble(txt_descuento.Text) / 100D);
                FirebaseResponse response = await client.UpdateAsync("Productos/" + productoSeleccionado.Codigo, productoSeleccionado);
                MessageBox.Show("El producto " + comboBox1.Text + " se actualizó con éxito", "Actualización correcta",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            
        }

        private void Datos_modificar_producto_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            llenarLista();
            comboBox1.SelectedIndex = -1;
        }

        private void bttn_atrás_Click(object sender, EventArgs e)
        {
            this.Hide();
            pantalla_dueño Pantalla_dueño = new pantalla_dueño();
            Pantalla_dueño.Show();
        }
    }
}
