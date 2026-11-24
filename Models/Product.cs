using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E3_Barroc_Intens.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace E3_Barroc_Intens.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required, MaxLength(20)]
        public string Code { get; set; } = string.Empty;

        [Required, MaxLength(150)]
        public string Naam { get; set; } = string.Empty;

        [MaxLength(100)]
        public string? Merk { get; set; }

        public string? Omschrijving { get; set; }

        public Productgroep Productgroep { get; set; }

        [Required, MaxLength(30)]
        public string Eenheid { get; set; } = string.Empty; 

        [Precision(10, 2)]
        public decimal PrijsExclBtw { get; set; }

        [Precision(5, 2)]
        public decimal BtwPercentage { get; set; } = 21m;

        [Precision(10, 2)]
        public decimal? Installatiekosten { get; set; }

        public int Voorraad { get; set; }

        public bool Actief { get; set; } = true;
    }
}
