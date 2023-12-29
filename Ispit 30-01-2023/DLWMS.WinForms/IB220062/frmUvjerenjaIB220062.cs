using DLWMS.Data;
using DLWMS.Data.IB220062;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IB220062
{
    public partial class frmUvjerenjaIB220062 : Form
    {
        private dtoStudentiIB220062 student;

        public frmUvjerenjaIB220062(dtoStudentiIB220062 std)
        {
            InitializeComponent();
            student = std;
            Text = std.BrojIndeksa;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
