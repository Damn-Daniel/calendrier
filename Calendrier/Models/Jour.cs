using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Calendrier.Models
{
    public class Jour
    {
        public string Page_couverture { get; set; }
        public Photo Photo { get; set; }

        [Display(Name = "Id")]
        public int Id { get; set; }
        public string Musique { get; set; }
        public DateTime day { get; set; }

        public bool ouvert { get; set; }
    }
}
