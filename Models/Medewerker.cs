using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E3_Barroc_Intens.Models.Enums;

namespace E3_Barroc_Intens.Models
{
    public class Medewerker
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Naam { get; set; } = string.Empty;

        [Required, MaxLength(50)]
        public string Gebruikersnaam { get; set; } = string.Empty;

        [Required, MaxLength(255)]
        public string WachtwoordHash { get; set; } = string.Empty;

        public Rol Rol { get; set; }

        public bool Actief { get; set; } = true;
    }
}
