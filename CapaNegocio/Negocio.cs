using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
using System.Data.SqlClient;

namespace CapaNegocio
{
    public class Negocio
    {
        Datos datos = new Datos();

        public string[]  Login_datos(string user, string pass)
        {
            return datos.Loging_datos(user, pass);
        }
        public void insertar_medicamentos(string id_paciente, string medicamento, string durante, string medidas)
        {
            datos.insertar_Medicamentos(id_paciente, medicamento, durante, medidas);
        }
    }
}
