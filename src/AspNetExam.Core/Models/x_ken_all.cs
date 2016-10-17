using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetExam.Models
{
    [Table("x_ken_all")]
    public class x_ken_all
    {
        public string JISX0401 { get; set; }
        public string OldZipCode { get; set; }
        [Key]
        public string NewZipCode { get; set; }
        public string PrefectureKana { get; set; }
        public string CityWardKana { get; set; }
        public string AddressKana { get; set; }
        public string Prefecture { get; set; }
        public string CityWard { get; set; }
        public string Address { get; set; }
        public string Dup1 { get; set; }
        public string WithNumber { get; set; }
        public string StreetNumber { get; set; }
        public string Dup2 { get; set; }
        public string Changed { get; set; }
        public string Detail { get; set; }
    }
}
