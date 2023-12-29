using DLWMS.Data;
using DLWMS.Data.IB220062;
using DLWMS.WinForms.Helpers;
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
    public partial class frmPretragaIB220062 : Form
    {
        public Student student;
        DLWMSDbContext db = KonekcijaIB220062.db;
        ErrorProvider err;
        List<dtoStudentiIB220062> Studenti = new List<dtoStudentiIB220062>();
        public frmPretragaIB220062()
        {
            InitializeComponent();
            err = new ErrorProvider();
            UcitajSpolove();
            dgvStudenti.AutoGenerateColumns = false;
        }

        private void UcitajSpolove()
        {
            cmbSpol.ValueMember = "Id";
            cmbSpol.DisplayMember = "Naziv";
            cmbSpol.DataSource = db.Spolovi.ToList();
            cmbSpol.SelectedIndex = -1;
        }

        private void UcitajPodatke()
        {
            var spol = cmbSpol.SelectedItem as Spol;
            var dtmOd = dtpOd.Value;
            var dtmDo = dtpDo.Value;
            var lista = db.Studenti.Include(x => x.Spol).Where(x => x.Spol.Id == spol.Id && (x.DatumRodjenja >= dtmOd && x.DatumRodjenja <= dtmDo)).ToList();
            dgvStudenti.DataSource = null;
            if(lista.Count == 0)
            {
                MessageBox.Show($"U bazi nema studenata koji su sljedećeg spola: " +
                    $"{spol.Naziv} i da su rođeni u periodu od {dtmOd.ToShortDateString()} " +
                    $"do {dtmDo.ToShortDateString()}");
            }
            else
            {
                Studenti.Clear();
                foreach(var std in lista)
                {
                    Studenti.Add(new dtoStudentiIB220062() { student = std });
                }
                dgvStudenti.DataSource = Studenti;

            }
        }

        private bool ValidniPodaci()
        {
            return Helpers.Validator.ValidirajKontrolu(cmbSpol, err, Kljucevi.ObaveznaVrijednost);
        }

        private void cmbSpol_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (ValidniPodaci())
                UcitajPodatke();
        }

        private void dtpOd_ValueChanged(object sender, EventArgs e)
        {
            if (ValidniPodaci())
                UcitajPodatke();
        }

        private void dtpDo_ValueChanged(object sender, EventArgs e)
        {
            if (ValidniPodaci())
                UcitajPodatke();
        }

        private void dgvStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex != 5)
            {
                var std = dgvStudenti.SelectedRows[0].DataBoundItem as dtoStudentiIB220062;
                var frm = new frmStudentIB220062(std);
                frm.ShowDialog();
            }
            else if(e.ColumnIndex == 5)
            {
                var std = dgvStudenti.SelectedRows[0].DataBoundItem as dtoStudentiIB220062;
                var frm = new frmUvjerenjaIB220062(std);
                frm.ShowDialog();
            }
        }
    }
}
