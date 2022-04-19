using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EbTbWebApp.Models
{
    public class Gazdi
    {
        public int id { get; set; }
        public string GazdiNev { get; set; }
        public string GazdiCim { get; set; }
        public string GazdiTelefon { get; set; }        
        public int AllatId { get; set; }        
        public string AllatNev { get; set; }
        public DateTime SzulIdo { get; set; }       
        public int FajId { get; set; }
        public int OltasId { get; set; }
    }
}
