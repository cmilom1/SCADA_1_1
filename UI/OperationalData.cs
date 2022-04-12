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
    public partial class OperationalData : Form
    {
        public OperationalData()
        {
            InitializeComponent();
            ListOperationalData();
        }
        private void ListOperationalData()
        {
            Data.MachinesData Machines = new Data.MachinesData();
            dataGridView1.DataSource = Machines.ListOperationalData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OperationalData_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
    }
}
