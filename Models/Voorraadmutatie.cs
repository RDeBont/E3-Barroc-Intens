using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_Barroc_Intens.Models
{
    public class Voorraadmutatie
    {
        public int Id { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;

        public int MedewerkerId { get; set; }
        public Medewerker Medewerker { get; set; } = null!;

        public DateTime Datum { get; set; } = DateTime.Now;

        // Positief = bij, negatief = af
        public int Aantal { get; set; }

        [Required, MaxLength(255)]
        public string Reden { get; set; } = string.Empty;
    }
}
