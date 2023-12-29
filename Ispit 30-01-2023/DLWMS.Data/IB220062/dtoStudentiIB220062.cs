using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IB220062
{
    public class dtoStudentiIB220062
    {
        public Student student { get; set; }
        public string BrojIndeksa => student.BrojIndeksa;
        public string ImePrezime => student.Ime + " " + student.Prezime;
        public string Prosjek => IzracunajProsjek();
        public DateTime Datum => student.DatumRodjenja;
        public bool Aktivan => student.Aktivan;
        private string IzracunajProsjek()
        {
            DLWMSDbContext db = new DLWMSDbContext();
            return db.StudentiPredmeti.Include(x => x.student).Where(x => x.student.Id == student.Id).Average(x => x.Ocjena).ToString("0.00");
        }

    }
}
