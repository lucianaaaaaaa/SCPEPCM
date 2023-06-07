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
    public partial class pantalla_empleado : Form
    {
        List<string> listaProductos = new List<string>();
        double costoTotal = 0;

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "ExAWzOGUGQ37zf9X2381ZGbRYxaxrVqlgzPpsAZZ",
            BasePath = "https://scpepcm-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        public pantalla_empleado()
        {
            InitializeComponent();
            cmb_productos.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_generar_comprobante_Click(object sender, EventArgs e)
        {
            Intermediario.costoTotal = costoTotal;
            this.Hide();
            generar_comprobante generar_Comprobante = new generar_comprobante();
            
            //MessageBox.Show(Intermediario.costoTotal.ToString());
            generar_Comprobante.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult mensaje = MessageBox.Show("¿Desea cerrar sesion?", "", MessageBoxButtons.OKCancel);
            if (mensaje == DialogResult.OK)
            {
                this.Hide();
                Inicio_Sesion inicio_Sesion = new Inicio_Sesion();
                inicio_Sesion.Show();

            }
        }

        private async void cmb_productos_preparacion()
        {
            listaProductos.Clear();
            FirebaseResponse responseAlmacén = await client.GetAsync("Reserva/Productos");
            Almacén reserva = responseAlmacén.ResultAs<Almacén>();

            for (int i = 0; i < reserva.Productos; i++)
            {
                FirebaseResponse responseProducto = await client.GetAsync("Productos/" + (1000 + i).ToString());
                Productos producto = responseProducto.ResultAs<Productos>();
                if (producto.Reserva != 0)
                {
                    listaProductos.Add(producto.Nombre);
                }
            }
            cmb_productos.DataSource = null;
            cmb_productos.DataSource = listaProductos;
        }

        private async void btn_agregar_canasta_Click(object sender, EventArgs e)
        {
            listaProductos.Clear();
            FirebaseResponse responseAlmacén = await client.GetAsync("Reserva/Productos");
            Almacén reserva = responseAlmacén.ResultAs<Almacén>();
            Intermediario.nombreCliente = txt_nombre_cliente.Text;
            Intermediario.nitCliente = txt_nit_cliente.Text;

            for (int i = 0; i < reserva.Productos; i++)
            {
                FirebaseResponse responseProducto = await client.GetAsync("Productos/" + (1000 + i).ToString());
                Productos producto = responseProducto.ResultAs<Productos>();
                if (producto.Nombre == cmb_productos.Text)
                {
                    if (Int32.Parse(txt_cantidad.Text) > producto.Reserva)
                    {
                        MessageBox.Show("No nos quedan tantos productos en la tienda, solo disponemos de " + producto.Reserva.ToString() + " productos de este tipo", "Falta de reservas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        producto.Reserva = producto.Reserva - Int32.Parse(txt_cantidad.Text);
                        Intermediario.canastas.Add(new Canasta
                        {
                            Producto = producto.Nombre,
                            Cantidad = txt_cantidad.Text,
                            CostoUnitario = producto.Costo.ToString(),
                            CostoTotal = (producto.Costo * Int32.Parse(txt_cantidad.Text)).ToString()
                        });
                        FirebaseResponse resp = await client.UpdateAsync("Productos/" + (reserva.Productos + 1000).ToString(), producto);
                        costoTotal += Convert.ToDouble(producto.Costo * Int32.Parse(txt_cantidad.Text));
                        MessageBox.Show("El producto " + cmb_productos.Text + " se agregó a la canasta", "Compra más",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_cantidad.Text = "";
                        cmb_productos.SelectedIndex = -1;

                    }
                    break;
                }
            }
            
        }

        private void pantalla_empleado_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            Intermediario.canastas.Clear();
            cmb_productos_preparacion();
        }
    }
}
