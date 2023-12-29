using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IB220062
{
    [Table("StudentiPredmeti")]
    public class StudentPredmetiIB220062
    {
        public int Id { get; set; }
        public Student student { get; set; }
        public PredmetIB220062 predmet { get; set; }
        public int Ocjena { get; set; }
        public DateTime Datum { get; set; }
    }
}
