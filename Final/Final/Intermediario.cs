using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    static class Intermediario
    {
        public static string userDueño = "eljefe"; //hay problemas con el "."
        public static string passDueño = "tengoplata123";
        public static bool soyElDueño = false;
        public static string nombreCliente;
        public static string nitCliente;
        public static List <Canasta> canastas = new List <Canasta>();
        public static int costoTotal;
    }
}
