using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;
using System.Data;
using System.Data.SqlClient;

namespace SCADA_1_1.UI
{
    public partial class Machine : Form
    {
        private SqlConnection Conn = new SqlConnection("SERVER=TBOGL011\\SCSOLDINTEG;DATABASE=DB_SCADA_1_0; Integrated security=true");

        public Machine()
        {
            InitializeComponent();
            NuevoMolde.Visible = false;
        }

        private void Machine_Load(object sender, EventArgs e)
        {

            string query1 = "SELECT MOLD_REFERENCE FROM SC_MOLD_REFERENCE WHERE MACHINE_INDEX = @MACHINE_INDEX";
            SqlCommand comando = new SqlCommand(query1, Conn);
            comando.Parameters.AddWithValue("@MACHINE_INDEX","14");
            Conn.Open();
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                ReferenciaMolde.Text = registro["MOLD_REFERENCE"].ToString();
            }
            Conn.Close();

        }

        private async void timer1_Tick(object sender, EventArgs e)
        {

            NombreMaquina.Text = "Inyectora " + Program.readDataMB[1].ToString();
            NumeroMaquina.Text = Program.readDataMB[1].ToString();
            CodigoOperario.Text = Program.readDataMB[2].ToString();
            TiempoTotalCiclo.Text = Program.readDataMB[4].ToString();
            TiempoInyeccion.Text = Program.readDataMB[5].ToString();
            TiempoCargue.Text = Program.readDataMB[6].ToString();
            VolumenMaterial.Text = Program.readDataMB[11].ToString();
            TempMoldeSuperior.Text = Program.readDataMB[8].ToString();
            TempMoldeInferior.Text = Program.readDataMB[9].ToString();
            moldeadas.Text = Program.readDataMB[3].ToString();
            //textBox15.Text = Program.readDataMB[3].ToString();
            TemperaturaAceite.Text = Program.readDataMB[10].ToString();
            TiempoVulcanizacion.Text = Program.readDataMB[7].ToString();
            CompuestoTotal.Text = Program.readDataMB[12].ToString();
            EficienciaProductiva.Text = Program.readDataMB[13].ToString();

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NuevoMolde.Visible == false)
            {
                NuevoMolde.Visible = true;
                Editar.Text = "Cancelar";
            }
            else
            {
                NuevoMolde.Visible = false;
                Editar.Text = "Editar";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "UPDATE SC_MOLD_REFERENCE SET MOLD_REFERENCE = @MOLD_REFERENCE";
            SqlCommand comando = new SqlCommand(query, Conn);
            int Referencia = Convert.ToInt16(NuevaReferencia.Text);
            comando.Parameters.AddWithValue("@MOLD_REFERENCE", Referencia);
            Conn.Open();
            comando.ExecuteNonQuery();
            Conn.Close();

            string query1 = "SELECT MOLD_REFERENCE FROM SC_MOLD_REFERENCE";
            SqlCommand comando1 = new SqlCommand(query1, Conn);
            Conn.Open();
            SqlDataReader registro = comando1.ExecuteReader();
            if (registro.Read())
            {
                ReferenciaMolde.Text = registro["MOLD_REFERENCE"].ToString();
            }
            Conn.Close();

            NuevoMolde.Visible = false;
            Editar.Text = "Editar";
        }
    }
}