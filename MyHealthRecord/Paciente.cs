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
    public partial class Paciente : Form
    {
        public Paciente()
        {
            InitializeComponent();
        }
        Negocio info = new Negocio();
        
        private void Paciente_Load(object sender, EventArgs e)
        {
            Panel panel = agregar(sender, e);
            Medicamentos.Controls.Add(panel);
            
        }

        private void Paciente_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void perfil_panel_Paint(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = Perfil;
        }

        private void medicamentos_p_Paint(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = Medicamentos;
        }

        private void Alergias_p_Paint(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = Enfermedades;
        }

        private void citas_p_Paint(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = Citas;
        }

        private void historial_p_Paint(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = Historial;
        }

        private void enfer_p_Paint(object sender, EventArgs e)
        {

            tabControl1.SelectedTab = Ajustes;
        }
        private Panel agregar(object sender, EventArgs e)
        {
            Panel panele1 = new Panel();
            panele1.Size = panel4.Size;
            panele1.Location = panel4.Location;
            panele1.BackColor = Color.Black;


            Panel elementos = new Panel();
            elementos.Size = panel1.Size;
            elementos.Location = panel1.Location;
            elementos.BackColor = Color.AliceBlue;


            Button boton = new Button();
            boton.Size = eliminar_medic.Size;
            boton.Location = eliminar_medic.Location;
            boton.BackColor = Color.White;



            panele1.Controls.Add(elementos);
            elementos.Controls.Add(boton);

           
            
            
            
            
            return panele1;
        }
        public void limpiar()
        {

        }

        private void add_medicamentos_Click(object sender, EventArgs e)
        {
            tiempo_med.SelectedIndex = 0;
            cantidad_med.SelectedIndex = 0;
            panel5.Visible = true;

        }

        private void guardar_mec_Click(object sender, EventArgs e)
        {
            string durante = cantidad_med.SelectedItem.ToString() + " vez por " + tiempo_med.SelectedItem.ToString();
            info.insertar_medicamentos(Entidades.id, medicamento.Text, durante, medida.Text);
            panel5.Visible = false;
        }

        private void cancelar_med_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
            limpiar();
        }
    }
}
