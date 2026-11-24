using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_Barroc_Intens.Models
{
    public class Klant
    {
        public int Id { get; set; }

        // Leeg (null) zolang het een prospect is
        [MaxLength(20)]
        public string? Klantnummer { get; set; }

        [Required, MaxLength(150)]
        public string Naam { get; set; } = string.Empty;

        [MaxLength(20)]
        public string? Telefoon { get; set; }

        [MaxLength(150)]
        public string? Email { get; set; }

        public bool IsKlant { get; set; }
        public bool Actief { get; set; } = true;

        // Bezoekadres 
        [MaxLength(100)] public string? BezoekStraat { get; set; }
        [MaxLength(10)] public string? BezoekHuisnummer { get; set; }
        [MaxLength(10)] public string? BezoekPostcode { get; set; }
        [MaxLength(100)] public string? BezoekPlaats { get; set; }

        // Factuuradres
        [MaxLength(100)] public string? FactuurStraat { get; set; }
        [MaxLength(10)] public string? FactuurHuisnummer { get; set; }
        [MaxLength(10)] public string? FactuurPostcode { get; set; }
        [MaxLength(100)] public string? FactuurPlaats { get; set; }

        // BKR-check
        public bool BkrUitgevoerd { get; set; }
        public DateTime? BkrDatum { get; set; }
        public int? BkrMedewerkerId { get; set; }
        public Medewerker? BkrMedewerker { get; set; }

        public List<Notitie> Notities { get; set; } = new();
        public List<Offerte> Offertes { get; set; } = new();
    }
}
