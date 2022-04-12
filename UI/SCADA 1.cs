using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace SCADA_1_1
{
    public partial class MainPanel : Form
    {
        int[] escrituraEnteros = new int[50];
        private SqlConnection Conn = new SqlConnection("SERVER=TBOGL011\\SCSOLDINTEG;DATABASE=DB_SCADA_1_0; Integrated security=true");
        public MainPanel()
        {
            InitializeComponent();
        }

        private void openFormHijo(object formHijo)
        {
            if (this.Contenedor1.Controls.Count > 0)
                this.Contenedor1.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Contenedor1.Controls.Add(fh);
            this.Contenedor1.Tag = fh;
            fh.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void MenuIcon_Click(object sender, EventArgs e)
        {
            if (Menu.Width == 194)
            {
                Menu.Width = 10;
            }
            else
                Menu.Width = 194;
        }

        private void InyectorasButton_Click(object sender, EventArgs e)
        {
            if (subMenu.Visible == false)
            {
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void Inyectora1Button_Click(object sender, EventArgs e)
        {
            openFormHijo(new UI.Machine());
        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            openFormHijo(new UI.Dashboard());
        }

        private void MainPanel_Load(object sender, EventArgs e)
        {
            DashboardButton_Click(null, e);
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            
            //ACTUALIZACION DE DATOS DE COMUNICACION

            Program.readDataMB = await Data.ComunicacionModbus.Start(escrituraEnteros);

            // INDICADORES DE CONEXION

            if (Program.readDataMB[0] == -999)
            {
                InyectorasStatusPilot.BackColor = Color.FromArgb(255, 153, 153);
                Inyectora1StatusPilot.BackColor = Color.FromArgb(255, 153, 153);
            }

            else
            {
                InyectorasStatusPilot.BackColor = Color.FromArgb(25, 247, 162);
                Inyectora1StatusPilot.BackColor = Color.FromArgb(25, 247, 162);}

            if (Program.readDataMB[0] == -999) { textBox1.Text = "Sin conexión con el PLC Principal"; }
            else { textBox1.Text = "PLC Principal OK"; }


            // INSERTAR DATOS EN DB
            if (Program.readDataMB[15] == 1)
            {

                string query2 = "INSERT INTO SC_OPERATIONAL_DATA(MACHINE_INDEX,DATETIME,NUMERO_MAQUINA,CODIGO_OPERARIO,REFERENCIA_MOLDE,NUMERO_MOLDEADA,TIEMPO_TOTAL_CICLO,TIEMPO_INYECCION,TIEMPO_CARGUE,TIEMPO_VULCANIZACION,TEMP_MOLDE_SUPERIOR,TEMP_MOLDE_INFERIOR,TEMP_ACEITE,VOLUMEN_MATERIAL,COMPUESTO_TOTAL,EFICIENCIA_PRODUCTIVA)VALUES(@MACHINE_INDEX,@DATETIME,@NUMERO_MAQUINA,@CODIGO_OPERARIO,@REFERENCIA_MOLDE,@NUMERO_MOLDEADA,@TIEMPO_TOTAL_CICLO,@TIEMPO_INYECCION,@TIEMPO_CARGUE,@TIEMPO_VULCANIZACION,@TEMP_MOLDE_SUPERIOR,@TEMP_MOLDE_INFERIOR,@TEMP_ACEITE,@VOLUMEN_MATERIAL,@COMPUESTO_TOTAL,@EFICIENCIA_PRODUCTIVA)";
                SqlCommand comando = new SqlCommand(query2, Conn);
                comando.Parameters.AddWithValue("@MACHINE_INDEX", 14);
                comando.Parameters.AddWithValue("@DATETIME", DateTime.Now);
                comando.Parameters.AddWithValue("@NUMERO_MAQUINA", Program.readDataMB[1]);
                comando.Parameters.AddWithValue("@CODIGO_OPERARIO", Program.readDataMB[2]);
                comando.Parameters.AddWithValue("@REFERENCIA_MOLDE", 0);
                comando.Parameters.AddWithValue("@NUMERO_MOLDEADA", Program.readDataMB[3]);
                comando.Parameters.AddWithValue("@TIEMPO_TOTAL_CICLO", Program.readDataMB[4]);
                comando.Parameters.AddWithValue("@TIEMPO_INYECCION", Program.readDataMB[5]);
                comando.Parameters.AddWithValue("@TIEMPO_CARGUE", Program.readDataMB[6]);
                comando.Parameters.AddWithValue("@TIEMPO_VULCANIZACION", Program.readDataMB[7]);
                comando.Parameters.AddWithValue("@TEMP_MOLDE_SUPERIOR", Program.readDataMB[8]);
                comando.Parameters.AddWithValue("@TEMP_MOLDE_INFERIOR", Program.readDataMB[9]);
                comando.Parameters.AddWithValue("@TEMP_ACEITE", Program.readDataMB[10]);
                comando.Parameters.AddWithValue("@VOLUMEN_MATERIAL", Program.readDataMB[11]);
                comando.Parameters.AddWithValue("@COMPUESTO_TOTAL", Program.readDataMB[12]);
                comando.Parameters.AddWithValue("@EFICIENCIA_PRODUCTIVA", Program.readDataMB[13]);
                Conn.Open();
                comando.ExecuteNonQuery();
                Conn.Close();
            }
        }

        private void HoraTimer_Tick(object sender, EventArgs e)
        {
            Hora.Text = DateTime.Now.ToLongTimeString();
        }

        private void ConfiguracionesButton_Click(object sender, EventArgs e)
        {
            openFormHijo(new UI.Configuraciones());
        }

        private void DatosOperativosButton_Click(object sender, EventArgs e)
        {
            openFormHijo(new UI.OperationalData());
        }

        private void InyectorasStatusPilot_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
