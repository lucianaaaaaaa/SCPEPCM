using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;


namespace Final
{
    public class DatabaseFirebase
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "ExAWzOGUGQ37zf9X2381ZGbRYxaxrVqlgzPpsAZZ",
            BasePath = "https://scpepcm-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        DatabaseFirebase()
        {
            client = new FireSharp.FirebaseClient(config);

            if (client != null)
            {
                //Conectado
            }
        }
        public async void addEmpleado(string usuario, string CI, string password,
            string fNacimiento, string fEntrada, string nacionalidad, string nombre)
        {
            var datalayerEmpleado = new Empleados
            {
                usuario = usuario,
                CI = CI,
                Password = password,
                FNac = fNacimiento,
                FEntrada = fEntrada,
                Nombre = nombre
            };

            SetResponse respEmpleado = await client.SetAsync("Empleados/" + usuario, datalayerEmpleado);
        }
        
    }
}
