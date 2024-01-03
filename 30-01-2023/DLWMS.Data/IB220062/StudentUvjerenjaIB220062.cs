using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IB220062
{
    [Table("StudentiUvjerenja")]
    public class StudentUvjerenjaIB220062
    {
        public int Id { get; set; }
        public Student student { get; set; }
        public DateTime VrijemeKreiranja { get; set; }
        public string VrstaUvjerenja { get; set; }
        public string SvrhaUvjerenja { get; set; }
        public bool Printano { get; set; }
        public byte []Uplatnica { get; set; }
    }
}
