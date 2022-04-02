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

namespace SCADA_1_1.UI
{
    public partial class Machine : Form
    {

        public Machine()
        {
            InitializeComponent();
        }

        private void Machine_Load(object sender, EventArgs e)
        {
        
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
           // Program.readDataMB = await Data.ComunicacionModbus.Start();
            textBox1.Text = Program.readDataMB[0].ToString();
            textBox2.Text = Program.readDataMB[1].ToString();
            textBox3.Text = Program.readDataMB[2].ToString();
            textBox4.Text = Program.readDataMB[3].ToString();
            textBox5.Text = Program.readDataMB[4].ToString();
            textBox6.Text = Program.readDataMB[5].ToString();


        }
    }
}
