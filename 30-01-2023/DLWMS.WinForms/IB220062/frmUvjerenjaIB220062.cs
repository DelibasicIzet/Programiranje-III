using DLWMS.Data;
using DLWMS.Data.IB220062;
using Microsoft.EntityFrameworkCore;
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
        DLWMSDbContext db = KonekcijaIB220062.db;
        private dtoStudentiIB220062 student;

        public frmUvjerenjaIB220062(dtoStudentiIB220062 std)
        {
            InitializeComponent();
            student = std;
            dgvUvjerenja.AutoGenerateColumns = false;
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            var lista = db.StudentiUvjerenja.Include(x => x.student).Where(x => x.student.Id == student.student.Id).ToList();
            Text = "Broj uvjerenja " + lista.Count.ToString();
            dgvUvjerenja.DataSource = null;
            dgvUvjerenja.DataSource = lista;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 5)
            {
                DialogResult rezultat = MessageBox.Show(this, "Da li zelite obrisati?", "Upozorenje", MessageBoxButtons.YesNo);
                if(rezultat == DialogResult.Yes)
                {
                    var uvjerenje = dgvUvjerenja.SelectedRows[0].DataBoundItem as StudentUvjerenjaIB220062;
                    db.StudentiUvjerenja.Remove(uvjerenje);
                    db.SaveChanges();
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnZahtjev_Click(object sender, EventArgs e)
        {
            var frm = new frmNovoUvjerenjeIB220062(student);
            frm.ShowDialog();
        }
    }
}
