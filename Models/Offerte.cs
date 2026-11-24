using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E3_Barroc_Intens.Models.Enums;

namespace E3_Barroc_Intens.Models
{
    public class Offerte
    {
        public int Id { get; set; }

        public int KlantId { get; set; }
        public Klant Klant { get; set; } = null!;

        public int MedewerkerId { get; set; }
        public Medewerker Medewerker { get; set; } = null!;

        public DateTime Offertedatum { get; set; } = DateTime.Now;

        public OfferteStatus Status { get; set; } = OfferteStatus.Concept;

        public List<Offerteregel> Regels { get; set; } = new();
    }
}
