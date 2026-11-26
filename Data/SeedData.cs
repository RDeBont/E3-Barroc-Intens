using System;
using E3_Barroc_Intens.Models;
using E3_Barroc_Intens.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace E3_Barroc_Intens.Data
{
    // Testdata. Wachtwoord van alle accounts: Welkom123!
    public static class SeedData
    {
        public static void Vul(ModelBuilder modelBuilder)
        {
            VulMedewerkers(modelBuilder);
            VulProducten(modelBuilder);
            VulKlanten(modelBuilder);
        }

        private static void VulMedewerkers(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Medewerker>().HasData(
                new Medewerker { Id = 1, Naam = "Beheerder", Gebruikersnaam = "admin", Rol = Rol.Admin, WachtwoordHash = "100000.r/PE/pviIkiGgDcWFq34UQ==.clYngbyeCR7q98fT+ojeHlfVN5NUIFQWgVFMl3SHuNc=" },
                new Medewerker { Id = 2, Naam = "Joris Pulles", Gebruikersnaam = "joris", Rol = Rol.Hoofd, WachtwoordHash = "100000.LP/YuMmQE5Kl5nzJFNB8QQ==.KJjW95Og2uJLAAFjcRvnVWtcC+TkQHtRgAs76arr2fo=" },
                new Medewerker { Id = 3, Naam = "Maarten Pulles", Gebruikersnaam = "maarten", Rol = Rol.Hoofd, WachtwoordHash = "100000.UDIBUjypaiuVeixbisx4wA==.+zOIY0F/o4zKQXpCFBW/Nk46e3EXupEwZqBbM9ApzlQ=" },
                new Medewerker { Id = 4, Naam = "John Vrees", Gebruikersnaam = "john", Rol = Rol.Hoofd, WachtwoordHash = "100000.Rpdo13XhII3pzm8BR36RsA==.hVH7zHCvuq+cp3dHIYihzTKRWeoIpmiFgPMu6aMvtA0=" },
                new Medewerker { Id = 5, Naam = "Simon Nagelkerke", Gebruikersnaam = "simon", Rol = Rol.Hoofd, WachtwoordHash = "100000.AI4/d9x8njT6a0z0YkG6fg==.TrRUNTV5DJfk9UgN3Xb3qNhyokpT4mubcubk+tGgo4s=" },
                new Medewerker { Id = 6, Naam = "Guillaume de Randamie", Gebruikersnaam = "guillaume", Rol = Rol.Sales, WachtwoordHash = "100000.3CPADBSqblFjTbe7r1WTig==.MpEVMgfElywuAi0AiPClgu8K/sgT2OYrb04R/alepu8=" },
                new Medewerker { Id = 7, Naam = "Annemie Meijaard", Gebruikersnaam = "annemie", Rol = Rol.Sales, WachtwoordHash = "100000.B0WnjD1u5wNW3o1hmN1JIg==.88xyhxOCWPDLgvUZEspZETWryeiRxprQy0YWvAhWHRQ=" },
                new Medewerker { Id = 8, Naam = "Ingeborg van Lier", Gebruikersnaam = "ingeborg", Rol = Rol.Finance, WachtwoordHash = "100000.2mDmSVOxusPhV+353bP5fw==.hEzGwWyZzfFbiPoPdWmbR+xIZ0MgQG2tXRAa8zIzYKo=" },
                new Medewerker { Id = 9, Naam = "Ashley van de Sluis", Gebruikersnaam = "ashley", Rol = Rol.Finance, WachtwoordHash = "100000.eBfn/qCBeAFV6tw8aGZOVQ==.UhH/k/Pn07F564WG8FfIgdyFyOCI79nUy8q2ymuofp0=" },
                new Medewerker { Id = 10, Naam = "Evelien Rosse", Gebruikersnaam = "evelien", Rol = Rol.Inkoop, WachtwoordHash = "100000.NxBWLqEd7iOB/+RvZ87A6g==.Pb8TPjcza5CjyiM2petVPyUb8NCDrBpz+0kxaqaYlH8=" },
                new Medewerker { Id = 11, Naam = "Max Roerdomp", Gebruikersnaam = "max", Rol = Rol.Inkoop, WachtwoordHash = "100000.EdwpdJ5+0Y/JaOPiBhRtnA==.Ru9kNxe4mcdca/X75LDzUE27yXcVgvL9/KG3kSXCiA8=" },
                new Medewerker { Id = 12, Naam = "Jimmy Choi", Gebruikersnaam = "jimmy", Rol = Rol.Planner, WachtwoordHash = "100000.ErRmY+pEXviHeFPiyVStvw==.UQKx4KORDmNo1XK73S8LMZEj+trd9wdVucNgw0C2Vb4=" },
                new Medewerker { Id = 13, Naam = "Muhammad Demir", Gebruikersnaam = "muhammad", Rol = Rol.Monteur, WachtwoordHash = "100000.LqkgLYQJ53eFgu/HcDVqsQ==.Bd+wImzL80Vvc7cOW58Gnb2W3PN0MAXlIWEaH3pqksY=" },
                new Medewerker { Id = 14, Naam = "Paul Machielsen", Gebruikersnaam = "paul", Rol = Rol.Monteur, WachtwoordHash = "100000.eD+nLxy+B2SDFMx+VYNB2w==.CNIVcwR/1EhaH87aHSzmpj2DKWp/Rnh4+Rs0BmRnIqg=" },
                new Medewerker { Id = 15, Naam = "Cindy Passier", Gebruikersnaam = "cindy", Rol = Rol.Monteur, WachtwoordHash = "100000.NG/jWd5tI8o6wv823NIqRQ==.YfMbRk+iR54reZJoiaK5i5AB6ggUe2UBoDPb4mh4mdY=" },
                new Medewerker { Id = 16, Naam = "Piotr Loszarowski", Gebruikersnaam = "piotr", Rol = Rol.Monteur, WachtwoordHash = "100000.ELNDsYLXbNdF3YwLM+sq4A==.YxW6/Xo8wMJ4zJU/ZG2VbgPTUuAnayA3FzfSISmOR84=" },
                // Inactief account om het inloggen mee te testen
                new Medewerker { Id = 17, Naam = "Henk Oud", Gebruikersnaam = "henk", Rol = Rol.Sales, WachtwoordHash = "100000.vbn1T0uGwvZXKbyAnoUCcw==.F/Hf1+BCJgNIpBr5gvkXU6TyTn3NCLQakdbUKzfiWPg=", Actief = false }
            );
        }

        private static void VulProducten(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                // Koffiemachines (prijs = lease per maand)
                new Product { Id = 1, Code = "S234FREKT", Naam = "Barroc Intens Italian Light", Merk = "Barroc Intens", Productgroep = Productgroep.Koffiemachines, Eenheid = "per maand", PrijsExclBtw = 499m, BtwPercentage = 21m, Installatiekosten = 289m, Voorraad = 8, Omschrijving = "Instapmodel, zonder bonenmaler." },
                new Product { Id = 2, Code = "S234KNDPF", Naam = "Barroc Intens Italian", Merk = "Barroc Intens", Productgroep = Productgroep.Koffiemachines, Eenheid = "per maand", PrijsExclBtw = 599m, BtwPercentage = 21m, Installatiekosten = 289m, Voorraad = 6, Omschrijving = "Standaardmodel, zonder bonenmaler." },
                new Product { Id = 3, Code = "S234NNBMV", Naam = "Barroc Intens Italian Deluxe", Merk = "Barroc Intens", Productgroep = Productgroep.Koffiemachines, Eenheid = "per maand", PrijsExclBtw = 799m, BtwPercentage = 21m, Installatiekosten = 375m, Voorraad = 4, Omschrijving = "Met ingebouwde koffiebonenmaler." },
                new Product { Id = 4, Code = "S234MMPLA", Naam = "Barroc Intens Italian Deluxe Special", Merk = "Barroc Intens", Productgroep = Productgroep.Koffiemachines, Eenheid = "per maand", PrijsExclBtw = 999m, BtwPercentage = 21m, Installatiekosten = 375m, Voorraad = 3, Omschrijving = "Topmodel met ingebouwde koffiebonenmaler." },

                // Koffiebonen (prijs per kg)
                new Product { Id = 5, Code = "S239KLIUP", Naam = "Espresso Beneficio", Merk = "Barroc Intens", Productgroep = Productgroep.Koffiebonen, Eenheid = "per kg", PrijsExclBtw = 21.60m, BtwPercentage = 9m, Voorraad = 40, Omschrijving = "Toegankelijke en zachte koffie uit de Matagalpa-regio in Nicaragua." },
                new Product { Id = 6, Code = "S239MNKLL", Naam = "Yellow Bourbon Brasil", Merk = "Barroc Intens", Productgroep = Productgroep.Koffiebonen, Eenheid = "per kg", PrijsExclBtw = 23.20m, BtwPercentage = 9m, Voorraad = 25, Omschrijving = "Zeldzame koffie van de oorspronkelijke Bourbon-struik met gele bessen." },
                new Product { Id = 7, Code = "S239IPPSD", Naam = "Espresso Roma", Merk = "Barroc Intens", Productgroep = Productgroep.Koffiebonen, Eenheid = "per kg", PrijsExclBtw = 20.80m, BtwPercentage = 9m, Voorraad = 40, Omschrijving = "Italiaanse espresso met een krachtig karakter en een aromatische afdronk." },
                new Product { Id = 8, Code = "S239EVVFS", Naam = "Red Honey Honduras", Merk = "Barroc Intens", Productgroep = Productgroep.Koffiebonen, Eenheid = "per kg", PrijsExclBtw = 27.80m, BtwPercentage = 9m, Voorraad = 15, Omschrijving = "Extra zoete koffie, gedroogd volgens de honey-methode." },

                // Onderhoudsonderdelen (prijs per stuk)
                new Product { Id = 9, Code = "OND-001", Naam = "Rubber (10 mm)", Productgroep = Productgroep.Onderhoudsonderdelen, Eenheid = "per stuk", PrijsExclBtw = 0.39m, BtwPercentage = 21m, Voorraad = 50 },
                new Product { Id = 10, Code = "OND-002", Naam = "Rubber (14 mm)", Productgroep = Productgroep.Onderhoudsonderdelen, Eenheid = "per stuk", PrijsExclBtw = 0.45m, BtwPercentage = 21m, Voorraad = 50 },
                new Product { Id = 11, Code = "OND-003", Naam = "Slang", Productgroep = Productgroep.Onderhoudsonderdelen, Eenheid = "per stuk", PrijsExclBtw = 4.45m, BtwPercentage = 21m, Voorraad = 20 },
                new Product { Id = 12, Code = "OND-004", Naam = "Voeding (elektra)", Productgroep = Productgroep.Onderhoudsonderdelen, Eenheid = "per stuk", PrijsExclBtw = 68.69m, BtwPercentage = 21m, Voorraad = 5 },
                new Product { Id = 13, Code = "OND-005", Naam = "Ontkalker", Productgroep = Productgroep.Onderhoudsonderdelen, Eenheid = "per stuk", PrijsExclBtw = 4.00m, BtwPercentage = 21m, Voorraad = 30 },
                new Product { Id = 14, Code = "OND-006", Naam = "Waterfilter", Productgroep = Productgroep.Onderhoudsonderdelen, Eenheid = "per stuk", PrijsExclBtw = 299.45m, BtwPercentage = 21m, Voorraad = 1 }, // bijna op
                new Product { Id = 15, Code = "OND-007", Naam = "Reservoir sensor", Productgroep = Productgroep.Onderhoudsonderdelen, Eenheid = "per stuk", PrijsExclBtw = 89.99m, BtwPercentage = 21m, Voorraad = 6 },
                new Product { Id = 16, Code = "OND-008", Naam = "Druppelstop", Productgroep = Productgroep.Onderhoudsonderdelen, Eenheid = "per stuk", PrijsExclBtw = 122.43m, BtwPercentage = 21m, Voorraad = 0 }, // uit voorraad
                new Product { Id = 17, Code = "OND-009", Naam = "Electrische pomp", Productgroep = Productgroep.Onderhoudsonderdelen, Eenheid = "per stuk", PrijsExclBtw = 478.59m, BtwPercentage = 21m, Voorraad = 2 }, // bijna op
                new Product { Id = 18, Code = "OND-010", Naam = "Tandwiel 110mm", Productgroep = Productgroep.Onderhoudsonderdelen, Eenheid = "per stuk", PrijsExclBtw = 5.45m, BtwPercentage = 21m, Voorraad = 15 },
                new Product { Id = 19, Code = "OND-011", Naam = "Tandwiel 70mm", Productgroep = Productgroep.Onderhoudsonderdelen, Eenheid = "per stuk", PrijsExclBtw = 5.25m, BtwPercentage = 21m, Voorraad = 15 },
                new Product { Id = 20, Code = "OND-012", Naam = "Maalmotor", Productgroep = Productgroep.Onderhoudsonderdelen, Eenheid = "per stuk", PrijsExclBtw = 119.20m, BtwPercentage = 21m, Voorraad = 4 },
                new Product { Id = 21, Code = "OND-013", Naam = "Zeef", Productgroep = Productgroep.Onderhoudsonderdelen, Eenheid = "per stuk", PrijsExclBtw = 28.80m, BtwPercentage = 21m, Voorraad = 10 },
                new Product { Id = 22, Code = "OND-014", Naam = "Reinigingstabletten", Productgroep = Productgroep.Onderhoudsonderdelen, Eenheid = "per stuk", PrijsExclBtw = 3.45m, BtwPercentage = 21m, Voorraad = 60 },
                new Product { Id = 23, Code = "OND-015", Naam = "Reinigingsborsteltjes", Productgroep = Productgroep.Onderhoudsonderdelen, Eenheid = "per stuk", PrijsExclBtw = 8.45m, BtwPercentage = 21m, Voorraad = 25 },
                new Product { Id = 24, Code = "OND-016", Naam = "Ontkalkingspijp", Productgroep = Productgroep.Onderhoudsonderdelen, Eenheid = "per stuk", PrijsExclBtw = 21.70m, BtwPercentage = 21m, Voorraad = 8 }
            );
        }

        private static void VulKlanten(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Klant>().HasData(
                // Klanten (met klantnummer)
                new Klant
                {
                    Id = 1,
                    Klantnummer = "15",
                    Naam = "Café De Kroon",
                    Telefoon = "076 123 4567",
                    Email = "info@dekroon.nl",
                    IsKlant = true,
                    BezoekStraat = "Grote Markt",
                    BezoekHuisnummer = "3",
                    BezoekPostcode = "4811 XA",
                    BezoekPlaats = "Breda",
                    FactuurStraat = "Grote Markt",
                    FactuurHuisnummer = "3",
                    FactuurPostcode = "4811 XA",
                    FactuurPlaats = "Breda",
                    BkrUitgevoerd = true,
                    BkrDatum = new DateTime(2026, 11, 12),
                    BkrMedewerkerId = 8
                },
                new Klant
                {
                    Id = 2,
                    Klantnummer = "16",
                    Naam = "Bistro Jan",
                    Telefoon = "0164 234 567",
                    Email = "jan@bistrojan.nl",
                    IsKlant = true,
                    BezoekStraat = "Markt",
                    BezoekHuisnummer = "12",
                    BezoekPostcode = "4611 GW",
                    BezoekPlaats = "Bergen op Zoom",
                    FactuurStraat = "Postbus",
                    FactuurHuisnummer = "88",
                    FactuurPostcode = "4600 AB",
                    FactuurPlaats = "Bergen op Zoom",
                    BkrUitgevoerd = true,
                    BkrDatum = new DateTime(2026, 6, 10),
                    BkrMedewerkerId = 9
                },

                // Prospects (geen klantnummer, nog geen BKR)
                new Klant
                {
                    Id = 3,
                    Naam = "Hotel Zuid",
                    Telefoon = "013 345 6789",
                    Email = "receptie@hotelzuid.nl",
                    IsKlant = false,
                    BezoekStraat = "Stationsplein",
                    BezoekHuisnummer = "1",
                    BezoekPostcode = "5038 CA",
                    BezoekPlaats = "Tilburg",
                    FactuurStraat = "Stationsplein",
                    FactuurHuisnummer = "1",
                    FactuurPostcode = "5038 CA",
                    FactuurPlaats = "Tilburg"
                },
                new Klant
                {
                    Id = 4,
                    Naam = "Lunchroom Bas",
                    Telefoon = "0165 456 789",
                    Email = "bas@lunchroombas.nl",
                    IsKlant = false,
                    BezoekStraat = "Kade",
                    BezoekHuisnummer = "4",
                    BezoekPostcode = "4703 GA",
                    BezoekPlaats = "Roosendaal",
                    FactuurStraat = "Kade",
                    FactuurHuisnummer = "4",
                    FactuurPostcode = "4703 GA",
                    FactuurPlaats = "Roosendaal"
                }
            );
        }
    }
}