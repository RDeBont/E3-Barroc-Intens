using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_Barroc_Intens.Models
{
    public class Notitie
    {
        public int Id { get; set; }

        public int KlantId { get; set; }
        public Klant Klant { get; set; } = null!;

        public int MedewerkerId { get; set; }
        public Medewerker Medewerker { get; set; } = null!;

        public DateTime Datum { get; set; } = DateTime.Now;

        [Required]
        public string Tekst { get; set; } = string.Empty;
    }
}
