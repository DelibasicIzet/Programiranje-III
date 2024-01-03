using DLWMS.Data;
using DLWMS.Data.IB220062;
using DLWMS.WinForms.Helpers;
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
    public partial class frmNovoUvjerenjeIB220062 : Form
    {
        dtoStudentiIB220062 student = new dtoStudentiIB220062();
        DLWMSDbContext db = KonekcijaIB220062.db;
        List<string> ListaIzbora = new List<string>() { "Uvjerenje o polozenim ispitima", "Uvjerenje o statusu studenta", "Uvjerenje za prosjek ocjena" };
        public frmNovoUvjerenjeIB220062(dtoStudentiIB220062 std)
        {
            InitializeComponent();
            student = std;
            cmbIzbor.DataSource = ListaIzbora;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (!Helpers.Validator.ValidirajKontrolu(txtSvrha, err, Kljucevi.ObaveznaVrijednost) ||
                !Helpers.Validator.ValidirajKontrolu(pictureBox1, err, Kljucevi.ObaveznaVrijednost))
                return;
            var svrha = txtSvrha.Text;
            var slika = ImageHelper.FromImageToByte(pictureBox1.Image);
            var vrsta = cmbIzbor.SelectedValue.ToString();
            StudentUvjerenjaIB220062 NovoUvjerenje = new StudentUvjerenjaIB220062()
            {
                Printano = false,
                SvrhaUvjerenja = svrha,
                Uplatnica = slika,
                VrstaUvjerenja = vrsta,
                VrijemeKreiranja = DateTime.Now,
                student = student.student
            };
            db.StudentiUvjerenja.Add(NovoUvjerenje);
            db.SaveChanges();
            MessageBox.Show("Uspjesno dodano uvjerenje!");
        }

        private void dodajSliku(object sender, MouseEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
    }
}
