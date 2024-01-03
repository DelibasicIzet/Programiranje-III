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
    public partial class frmStudentIB220062 : Form
    {
        private dtoStudentiIB220062 student;
        public frmStudentIB220062(dtoStudentiIB220062 std)
        {
            InitializeComponent();
            student = std;
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            lblImeStudenta.Text = student.ImePrezime;
            lblProsjek.Text = student.Prosjek;
            pbStudent.Image = ImageHelper.FromByteToImage(student.student.Slika);
            Text = student.BrojIndeksa;

        }

       
    }
}
