using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCADA_1_1.UI
{
    public partial class Configuraciones : Form
    {
        public Configuraciones()
        {
            InitializeComponent();
        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "";
            }
            else
            {
                Program.PLCip = textBox1.Text;
            }
            
            if (textBox2.Text == "")
            {
                textBox2.Text = "";
            }
            else
            {
                Program.DBInstance = textBox2.Text;
            }
            
        }
    }
}
