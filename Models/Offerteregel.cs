using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace E3_Barroc_Intens.Models
{
    public class Offerteregel
    {
        public int Id { get; set; }

        public int OfferteId { get; set; }
        public Offerte Offerte { get; set; } = null!;

        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;

        public int Aantal { get; set; }

        [Required, MaxLength(30)]
        public string Eenheid { get; set; } = string.Empty;

        // Eigen kopie van de prijs, zodat een oude offerte blijft kloppen als de productprijs verandert
        [Precision(10, 2)]
        public decimal PrijsExclBtw { get; set; }
    }
}
