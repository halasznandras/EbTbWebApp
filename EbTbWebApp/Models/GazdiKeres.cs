using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EbTbWebApp.Models
{
    public class GazdiKeres
    {
        public List<Gazdi> Gazdik { get; set; }
        public string KeresNev { get; set; }
        public string KeresAllat { get; set; }
        public SelectList AllatId { get; set; }
    }
}
