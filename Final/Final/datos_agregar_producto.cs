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
    public partial class datos_agregar_producto : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "ExAWzOGUGQ37zf9X2381ZGbRYxaxrVqlgzPpsAZZ",
            BasePath = "https://scpepcm-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        public datos_agregar_producto()
        {
            InitializeComponent();
        }

        private async void btn_agregar_producto_Click(object sender, EventArgs e)
        {
            if(txt_nombre_producto.Text=="" || txt_costo_producto.Text==""|| txt_cantidad_producto.Text == "")
            {
                var datalayerAlmacen = new Almacén
                {
                    Productos = 0
                };
                SetResponse respi = await client.SetAsync("Reserva", datalayerAlmacen);
                Almacén resultA = respi.ResultAs<Almacén>();
                MessageBox.Show("Todos los campos deben estar llenos", "No se puede agregar producto",  MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
            else
            {
                FirebaseResponse responseAlmacén = await client.GetAsync("Reserva/Productos");
                Almacén reserva = responseAlmacén.ResultAs<Almacén>();

                for (int i = 0; i < reserva.Productos; i++)
                {
                    FirebaseResponse responseProducto = await client.GetAsync("Productos/" + (1000+i).ToString());
                    Productos producto = responseProducto.ResultAs<Productos>();
                    if(producto.Nombre == txt_nombre_producto.Text)
                    {
                        MessageBox.Show("Este producto ya existe, no se puede agregar", "Falla al agregar Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Close();
                    }
                }

                    var datalayerProducto = new Productos
                    {
                        Codigo = (reserva.Productos+1000).ToString(),
                        Nombre = txt_nombre_producto.Text,
                        Costo = Int32.Parse(txt_costo_producto.Text),
                        Reserva = Int32.Parse(txt_cantidad_producto.Text)
                    };
                    var datalayerAlmacén = new Almacén
                    {
                        Productos = reserva.Productos + 1
                    };
                    SetResponse resp = await client.SetAsync("Productos/"+ (reserva.Productos + 1000).ToString(), datalayerProducto);
                    SetResponse respA = await client.SetAsync("Reserva/Productos", datalayerAlmacén);
                    Productos result = resp.ResultAs<Productos>();
                    Almacén resultA = resp.ResultAs<Almacén>();
            }
        }

        private void datos_agregar_producto_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
        }

        private void bttn_atrás_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
