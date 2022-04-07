using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCADA_1_1
{
    public partial class MainPanel : Form
    {
        int[] escrituraEnteros = new int[50];
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
            Program.readDataMB = await Data.ComunicacionModbus.Start(escrituraEnteros);

            if (Program.readDataMB[0] < 10) { 
                InyectorasStatusPilot.BackColor = Color.FromArgb(255, 153, 153); }
            else
                InyectorasStatusPilot.BackColor = Color.FromArgb(25, 247, 162);

            if (Program.readDataMB[0] == -999) { textBox1.Text = "Sin conexión con el PLC Principal"; }
            else { textBox1.Text = "PLC Principal OK"; }

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
    }
}
