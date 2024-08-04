using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winfrom_vs_sql_sever
{
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form15_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlybanhangDataSet.VATTU' table. You can move, or remove it, as needed.
            this.vATTUTableAdapter.Fill(this.quanlybanhangDataSet.VATTU);

        }
    }
}
