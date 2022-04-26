using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class Datos
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Con"].ConnectionString);


        public string[] Loging_datos(string user, string pass)
        {
            con.Open();
            SqlCommand command = new SqlCommand("Loing", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@user", user);
            command.Parameters.Add("@pass", pass);
            SqlDataReader reader = command.ExecuteReader();
            string permiso = "null";
            string id = "null";
            if (reader.Read())
            {
                 permiso = reader["permisos"].ToString();
                 id = reader["id"].ToString();
            }
            
            con.Close();
            string[] lista = { permiso, id };
            return lista;
        }

        public void insertar_Medicamentos(string id_paciente, string medicamento, string durante, string medidas)
        {

            con.Open();
            SqlDataReader id_med = new SqlCommand("select max(id)+1 as \"ID\" from Medicamentos", con).ExecuteReader();
            id_med.Read();
            string id_ = (( id_med["ID"].ToString() == "Null") ? "1" : id_med["ID"].ToString());
            con.Close();
            con.Open();
            Console.WriteLine(id_paciente);
            SqlCommand command = new SqlCommand("add_medicamentos", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@medicamento", medicamento);
            command.Parameters.Add("@medidas", medidas);
            command.Parameters.Add("@durante", durante);
            command.Parameters.Add("@id", Convert.ToInt32(id_paciente));
            command.Parameters.Add("@id_medicamento", id_);
            command.ExecuteNonQuery();
            con.Close();

 
        }
        public string[] get_medicamentos(int id)
        {
            con.Open();

            SqlCommand command = new SqlCommand("get_medicamentos", con);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@id", id);

            SqlDataReader sql = command.ExecuteReader();
            string[] medicamentos;
            string medicamento; string durante; string medidas;
            if (sql.Read())
            {
                
            }

        }
        




    }
}
