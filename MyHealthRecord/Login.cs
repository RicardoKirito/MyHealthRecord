using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;

namespace MyHealthRecord
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        Negocio loginf = new Negocio();

        private void Acceder_Click(object sender, EventArgs e)
        {
            string permiso = loginf.Login_datos(username.Text, pass.Text)[0];
            string id = loginf.Login_datos(username.Text, pass.Text)[1];
            Entidades.id = id;

            if (permiso!= "null" && permiso != "")
            {
                if(permiso == "doc")
                {

                }else if(permiso == "adm")
                {

                }
                else if(permiso == "pac")
                {
                    
                    this.Hide();
                    Paciente pt = new Paciente();
                    pt.Show();
                    
                    
                }
            }
        }
    }
}
