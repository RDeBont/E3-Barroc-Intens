using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace E3_Barroc_Intens.Migrations
{
    /// <inheritdoc />
    public partial class SeedTestdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Klanten",
                columns: new[] { "Id", "Actief", "BezoekHuisnummer", "BezoekPlaats", "BezoekPostcode", "BezoekStraat", "BkrDatum", "BkrMedewerkerId", "BkrUitgevoerd", "Email", "FactuurHuisnummer", "FactuurPlaats", "FactuurPostcode", "FactuurStraat", "IsKlant", "Klantnummer", "Naam", "Telefoon" },
                values: new object[,]
                {
                    { 3, true, "1", "Tilburg", "5038 CA", "Stationsplein", null, null, false, "receptie@hotelzuid.nl", "1", "Tilburg", "5038 CA", "Stationsplein", false, null, "Hotel Zuid", "013 345 6789" },
                    { 4, true, "4", "Roosendaal", "4703 GA", "Kade", null, null, false, "bas@lunchroombas.nl", "4", "Roosendaal", "4703 GA", "Kade", false, null, "Lunchroom Bas", "0165 456 789" }
                });

            migrationBuilder.InsertData(
                table: "Medewerkers",
                columns: new[] { "Id", "Actief", "Gebruikersnaam", "Naam", "Rol", "WachtwoordHash" },
                values: new object[,]
                {
                    { 1, true, "admin", "Beheerder", "Admin", "100000.r/PE/pviIkiGgDcWFq34UQ==.clYngbyeCR7q98fT+ojeHlfVN5NUIFQWgVFMl3SHuNc=" },
                    { 2, true, "joris", "Joris Pulles", "Hoofd", "100000.LP/YuMmQE5Kl5nzJFNB8QQ==.KJjW95Og2uJLAAFjcRvnVWtcC+TkQHtRgAs76arr2fo=" },
                    { 3, true, "maarten", "Maarten Pulles", "Hoofd", "100000.UDIBUjypaiuVeixbisx4wA==.+zOIY0F/o4zKQXpCFBW/Nk46e3EXupEwZqBbM9ApzlQ=" },
                    { 4, true, "john", "John Vrees", "Hoofd", "100000.Rpdo13XhII3pzm8BR36RsA==.hVH7zHCvuq+cp3dHIYihzTKRWeoIpmiFgPMu6aMvtA0=" },
                    { 5, true, "simon", "Simon Nagelkerke", "Hoofd", "100000.AI4/d9x8njT6a0z0YkG6fg==.TrRUNTV5DJfk9UgN3Xb3qNhyokpT4mubcubk+tGgo4s=" },
                    { 6, true, "guillaume", "Guillaume de Randamie", "Sales", "100000.3CPADBSqblFjTbe7r1WTig==.MpEVMgfElywuAi0AiPClgu8K/sgT2OYrb04R/alepu8=" },
                    { 7, true, "annemie", "Annemie Meijaard", "Sales", "100000.B0WnjD1u5wNW3o1hmN1JIg==.88xyhxOCWPDLgvUZEspZETWryeiRxprQy0YWvAhWHRQ=" },
                    { 8, true, "ingeborg", "Ingeborg van Lier", "Finance", "100000.2mDmSVOxusPhV+353bP5fw==.hEzGwWyZzfFbiPoPdWmbR+xIZ0MgQG2tXRAa8zIzYKo=" },
                    { 9, true, "ashley", "Ashley van de Sluis", "Finance", "100000.eBfn/qCBeAFV6tw8aGZOVQ==.UhH/k/Pn07F564WG8FfIgdyFyOCI79nUy8q2ymuofp0=" },
                    { 10, true, "evelien", "Evelien Rosse", "Inkoop", "100000.NxBWLqEd7iOB/+RvZ87A6g==.Pb8TPjcza5CjyiM2petVPyUb8NCDrBpz+0kxaqaYlH8=" },
                    { 11, true, "max", "Max Roerdomp", "Inkoop", "100000.EdwpdJ5+0Y/JaOPiBhRtnA==.Ru9kNxe4mcdca/X75LDzUE27yXcVgvL9/KG3kSXCiA8=" },
                    { 12, true, "jimmy", "Jimmy Choi", "Planner", "100000.ErRmY+pEXviHeFPiyVStvw==.UQKx4KORDmNo1XK73S8LMZEj+trd9wdVucNgw0C2Vb4=" },
                    { 13, true, "muhammad", "Muhammad Demir", "Monteur", "100000.LqkgLYQJ53eFgu/HcDVqsQ==.Bd+wImzL80Vvc7cOW58Gnb2W3PN0MAXlIWEaH3pqksY=" },
                    { 14, true, "paul", "Paul Machielsen", "Monteur", "100000.eD+nLxy+B2SDFMx+VYNB2w==.CNIVcwR/1EhaH87aHSzmpj2DKWp/Rnh4+Rs0BmRnIqg=" },
                    { 15, true, "cindy", "Cindy Passier", "Monteur", "100000.NG/jWd5tI8o6wv823NIqRQ==.YfMbRk+iR54reZJoiaK5i5AB6ggUe2UBoDPb4mh4mdY=" },
                    { 16, true, "piotr", "Piotr Loszarowski", "Monteur", "100000.ELNDsYLXbNdF3YwLM+sq4A==.YxW6/Xo8wMJ4zJU/ZG2VbgPTUuAnayA3FzfSISmOR84=" },
                    { 17, false, "henk", "Henk Oud", "Sales", "100000.vbn1T0uGwvZXKbyAnoUCcw==.F/Hf1+BCJgNIpBr5gvkXU6TyTn3NCLQakdbUKzfiWPg=" }
                });

            migrationBuilder.InsertData(
                table: "Producten",
                columns: new[] { "Id", "Actief", "BtwPercentage", "Code", "Eenheid", "Installatiekosten", "Merk", "Naam", "Omschrijving", "PrijsExclBtw", "Productgroep", "Voorraad" },
                values: new object[,]
                {
                    { 1, true, 21m, "S234FREKT", "per maand", 289m, "Barroc Intens", "Barroc Intens Italian Light", "Instapmodel, zonder bonenmaler.", 499m, "Koffiemachines", 8 },
                    { 2, true, 21m, "S234KNDPF", "per maand", 289m, "Barroc Intens", "Barroc Intens Italian", "Standaardmodel, zonder bonenmaler.", 599m, "Koffiemachines", 6 },
                    { 3, true, 21m, "S234NNBMV", "per maand", 375m, "Barroc Intens", "Barroc Intens Italian Deluxe", "Met ingebouwde koffiebonenmaler.", 799m, "Koffiemachines", 4 },
                    { 4, true, 21m, "S234MMPLA", "per maand", 375m, "Barroc Intens", "Barroc Intens Italian Deluxe Special", "Topmodel met ingebouwde koffiebonenmaler.", 999m, "Koffiemachines", 3 },
                    { 5, true, 9m, "S239KLIUP", "per kg", null, "Barroc Intens", "Espresso Beneficio", "Toegankelijke en zachte koffie uit de Matagalpa-regio in Nicaragua.", 21.60m, "Koffiebonen", 40 },
                    { 6, true, 9m, "S239MNKLL", "per kg", null, "Barroc Intens", "Yellow Bourbon Brasil", "Zeldzame koffie van de oorspronkelijke Bourbon-struik met gele bessen.", 23.20m, "Koffiebonen", 25 },
                    { 7, true, 9m, "S239IPPSD", "per kg", null, "Barroc Intens", "Espresso Roma", "Italiaanse espresso met een krachtig karakter en een aromatische afdronk.", 20.80m, "Koffiebonen", 40 },
                    { 8, true, 9m, "S239EVVFS", "per kg", null, "Barroc Intens", "Red Honey Honduras", "Extra zoete koffie, gedroogd volgens de honey-methode.", 27.80m, "Koffiebonen", 15 },
                    { 9, true, 21m, "OND-001", "per stuk", null, null, "Rubber (10 mm)", null, 0.39m, "Onderhoudsonderdelen", 50 },
                    { 10, true, 21m, "OND-002", "per stuk", null, null, "Rubber (14 mm)", null, 0.45m, "Onderhoudsonderdelen", 50 },
                    { 11, true, 21m, "OND-003", "per stuk", null, null, "Slang", null, 4.45m, "Onderhoudsonderdelen", 20 },
                    { 12, true, 21m, "OND-004", "per stuk", null, null, "Voeding (elektra)", null, 68.69m, "Onderhoudsonderdelen", 5 },
                    { 13, true, 21m, "OND-005", "per stuk", null, null, "Ontkalker", null, 4.00m, "Onderhoudsonderdelen", 30 },
                    { 14, true, 21m, "OND-006", "per stuk", null, null, "Waterfilter", null, 299.45m, "Onderhoudsonderdelen", 1 },
                    { 15, true, 21m, "OND-007", "per stuk", null, null, "Reservoir sensor", null, 89.99m, "Onderhoudsonderdelen", 6 },
                    { 16, true, 21m, "OND-008", "per stuk", null, null, "Druppelstop", null, 122.43m, "Onderhoudsonderdelen", 0 },
                    { 17, true, 21m, "OND-009", "per stuk", null, null, "Electrische pomp", null, 478.59m, "Onderhoudsonderdelen", 2 },
                    { 18, true, 21m, "OND-010", "per stuk", null, null, "Tandwiel 110mm", null, 5.45m, "Onderhoudsonderdelen", 15 },
                    { 19, true, 21m, "OND-011", "per stuk", null, null, "Tandwiel 70mm", null, 5.25m, "Onderhoudsonderdelen", 15 },
                    { 20, true, 21m, "OND-012", "per stuk", null, null, "Maalmotor", null, 119.20m, "Onderhoudsonderdelen", 4 },
                    { 21, true, 21m, "OND-013", "per stuk", null, null, "Zeef", null, 28.80m, "Onderhoudsonderdelen", 10 },
                    { 22, true, 21m, "OND-014", "per stuk", null, null, "Reinigingstabletten", null, 3.45m, "Onderhoudsonderdelen", 60 },
                    { 23, true, 21m, "OND-015", "per stuk", null, null, "Reinigingsborsteltjes", null, 8.45m, "Onderhoudsonderdelen", 25 },
                    { 24, true, 21m, "OND-016", "per stuk", null, null, "Ontkalkingspijp", null, 21.70m, "Onderhoudsonderdelen", 8 }
                });

            migrationBuilder.InsertData(
                table: "Klanten",
                columns: new[] { "Id", "Actief", "BezoekHuisnummer", "BezoekPlaats", "BezoekPostcode", "BezoekStraat", "BkrDatum", "BkrMedewerkerId", "BkrUitgevoerd", "Email", "FactuurHuisnummer", "FactuurPlaats", "FactuurPostcode", "FactuurStraat", "IsKlant", "Klantnummer", "Naam", "Telefoon" },
                values: new object[,]
                {
                    { 1, true, "3", "Breda", "4811 XA", "Grote Markt", new DateTime(2026, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, true, "info@dekroon.nl", "3", "Breda", "4811 XA", "Grote Markt", true, "15", "Café De Kroon", "076 123 4567" },
                    { 2, true, "12", "Bergen op Zoom", "4611 GW", "Markt", new DateTime(2026, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, true, "jan@bistrojan.nl", "88", "Bergen op Zoom", "4600 AB", "Postbus", true, "16", "Bistro Jan", "0164 234 567" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Klanten",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Klanten",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Klanten",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Klanten",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Medewerkers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Medewerkers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Medewerkers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Medewerkers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Medewerkers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Medewerkers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Medewerkers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Medewerkers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Medewerkers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Medewerkers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Medewerkers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Medewerkers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Medewerkers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Medewerkers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Medewerkers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Producten",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Producten",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Producten",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Producten",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Producten",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Producten",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Producten",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Producten",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Producten",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Producten",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Producten",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Producten",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Producten",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Producten",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Producten",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Producten",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Producten",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Producten",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Producten",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Producten",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Producten",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Producten",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Producten",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Producten",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Medewerkers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Medewerkers",
                keyColumn: "Id",
                keyValue: 9);
        }
    }
}
