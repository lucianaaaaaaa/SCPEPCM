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
            if(txt_nombre_producto.Text=="" || txt_codigo_producto.Text=="" || txt_costo_producto.Text==""|| txt_cantidad_producto.Text == "")
            {
                MessageBox.Show("Todos los campos deben estar llenos", "No se puede agregar producto",  MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
            else
            {
                /*var datalayerProducto = new Productos
                {
                    Codigo = "1001",
                    Nombre = "Cigarros",
                    Costo = "3",
                    Reserva = "20"
                };
                SetResponse resp = await client.SetAsync("Productos/" + txt_codigo_producto.Text, datalayerProducto);
                Productos result = resp.ResultAs<Productos>();*/
                FirebaseResponse responseProducto = await client.GetAsync("Productos/" + txt_codigo_producto.Text);
                Productos producto = responseProducto.ResultAs<Productos>();
                if(producto != null)
                {
                    MessageBox.Show("Este producto ya existe, no se puede agregar", "Falla al agregar Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var datalayerProducto = new Productos
                    {
                        Codigo = txt_codigo_producto.Text,
                        Nombre = txt_nombre_producto.Text,
                        Costo = txt_costo_producto.Text,
                        Reserva = txt_cantidad_producto.Text
                    };
                    SetResponse resp = await client.SetAsync("Productos/"+txt_codigo_producto.Text, datalayerProducto);
                    Productos result = resp.ResultAs<Productos>();
                }
            }
        }

        private void datos_agregar_producto_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
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
