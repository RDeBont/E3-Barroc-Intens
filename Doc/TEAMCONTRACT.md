# Teamcontract – E3 Barroc Intens

**Team:** Twinks
**Teamleden:** Djay, Sem, Giovanni en Rowan
**Datum:** 26-11-2026

---

## 1. Teamgegevens en rollen

| Naam | Contact | GitHub | Rol |
|---|---|---|---|
| Djay Verlaar | D307960@edu.curio.nl | Djay Verlaar | Scrum Master / voorzitter |
| Sem | Djh0032@edu.curio.nl | SemTheDutchMan | Product Owner-contact |
| Giovanni van der Weegen | giovanni.vanderweegen@gmail.com | Giovanni127714 | Tester en notulist |
| Rowan de Bont | rowandebont@outlook.com | RDeBont | Git-beheerder (beheert `main`, `develop` en releases) |

**Wat de rollen inhouden**

- **Scrum Master:** leidt de stand-up en de retrospective, verdeelt de taken en spreekt teamleden aan op afspraken.
- **Product Owner-contact:** is het aanspreekpunt voor de docent of klant en legt vragen over de scope aan hen voor.
- **Tester:** test elke pull request handmatig aan de hand van de acceptatiecriteria.
- **Notulist:** maakt de notulen van stand-ups en teamvergaderingen en zet besluiten in het besluitendocument.
- **Git-beheerder:** beheert de branches, merget `develop` naar `main` aan het eind van de sprint en lost merge conflicts op (zie H6).

**Rouleren**

- De rollen rouleren niet vast. Een rol mag alleen wisselen met een geldige reden, bijvoorbeeld: "Ik kan de tests niet doen, want ik loop te ver achter met mijn tickets."
- Je meldt een wissel bij de Scrum Master. Die zet de wissel in de notulen.
- Bij elke retrospective kijken we of de rolverdeling nog werkt.

## 2. Communicatie en overleg

| Kanaal | Waarvoor |
|---|---|
| Discord | Al het overleg en het delen van informatie buiten de les. Afmelden doe je in het kanaal `#afwezigheid`. |
| GitHub Issues + Projects | Tickets, voortgang (kanbanbord) en vragen over een specifiek ticket |
| GitHub Pull Requests | Code reviews en feedback op code |
| In de les | Stand-up en directe afstemming |

**Reactietijd**

- Op schooldagen en doordeweeks reageer je tussen 08:00 en 21:00 binnen **4 uur**.
- In het weekend reageer je binnen **12 uur**.
- Een bericht na 21:00 telt als verstuurd om 08:00 de volgende ochtend.
- Een reactie mag kort zijn, bijvoorbeeld "gezien, ik kijk er vanavond naar".

**Stand-up**

- Elke projectles, direct aan het begin, voordat we aan het project beginnen.
- Maximaal **15 minuten**.
- Iedereen beantwoordt drie vragen:
  1. Wat heb ik sinds de vorige stand-up gedaan?
  2. Wat ga ik vandaag doen?
  3. Waar loop ik vast?
- De notulist schrijft de korte notulen.

**Besluiten**

- Besluiten zetten we in het besluitendocument (Word) in de gedeelde projectmap, met de datum en wie erbij was.
- Op basis van dat document passen we waar nodig de scope of de tickets aan.

## 3. Beschikbaarheid en werktijden

- We werken in elk geval aan het project tijdens de projectlessen op school (9 uur en 45 minuten per week).
- Werk je thuis verder, dan zet je je ticket op het bord op **In progress**.
- Van elk teamlid verwachten we **minimaal 10 uur per week** aan het project.
- Ben je een dag niet beschikbaar (bijbaan, stage, sport, afspraak)? Dan meld je dat in `#afwezigheid` op Discord of in de les, uiterlijk de dag ervoor.

## 4. Afwezigheid en uitval

**Gepland afwezig** (afspraak, vakantie)

- Je meldt het minimaal **2 schooldagen van tevoren** in `#afwezigheid` en tagt de Scrum Master.
- Een vakantie of een afwezigheid van meerdere dagen meld je minimaal **1 week van tevoren**.

**Onverwacht afwezig** (ziek)

- Je meldt je af **vóór 08:30** op de dag zelf in `#afwezigheid`.
- Je zet erbij of je thuis nog iets kunt doen.

**Overdracht**

Voordat je afwezig bent (of bij ziekte zo snel als het lukt) zorg je dat:

1. al je werk gecommit en **gepusht** is naar je feature branch;
2. de status van je ticket op het bord klopt;
3. er een korte notitie als comment in het ticket staat: wat is af, wat moet nog en waar loop je tegenaan.

**Wie neemt over?**

- De Scrum Master beslist of je taak blijft liggen of wordt overgenomen.
- Bij overnemen kiest de Scrum Master het teamlid met de minste openstaande tickets.
- De notulist zet de overname in de notulen, zodat we zien of dit eerlijk verdeeld wordt.

**Langdurig afwezig** (meer dan een week)

- Ben je langer dan **5 schooldagen** afwezig, dan licht het Product Owner-contact de docent in.
- Samen met de docent kijken we dan hoe de taken verdeeld worden.
- De docent of SLB'er schakelen we eerder in als duidelijk is dat iemand langer uitvalt.

**Ongemeld afwezig**

- Is iemand er niet en heeft die niets laten weten? Dan stuurt de Scrum Master dezelfde dag een bericht.
- Komt er binnen **24 uur** geen reactie, dan gaan we naar stap 2 van H9 (bespreking in de teamvergadering + notulen).
- Gebeurt het een **tweede keer**, dan gaan we direct naar stap 3: een gesprek met de docent.

**Inhalen**

- Wie iets gemist heeft, leest de notulen, het besluitendocument en de bijgewerkte tickets.
- Daarna praat een teamlid de persoon in maximaal 15 minuten bij in de eerstvolgende les.
- Gemist werk haal je in je eigen tijd in, binnen één week, tenzij we in de teamvergadering iets anders afspreken.

## 5. Taakverdeling en planning

- **Takenbord:** GitHub Projects (kanban: Todo → In progress → In review → Done).
- **Verdeling:** de Scrum Master verdeelt de taken eerlijk aan het begin van de sprint.
- Een vrij ticket mag je zelf oppakken: je wijst het aan jezelf toe en zet het op In progress.
- Je hebt maximaal 2 tickets tegelijk op In progress.

**Definition of Done**

Een taak is pas af als:

- [ ] alle acceptatiecriteria in het issue afgevinkt zijn;
- [ ] de code buildt zonder fouten;
- [ ] de tester het handmatig getest heeft;
- [ ] de pull request goedgekeurd is en naar `develop` gemerged is;
- [ ] het ticket op het bord op **Done** staat.

**Vastlopen**

- Een taak mag maximaal **1 les** zonder voortgang op In progress staan.
- Daarna meld je het in de volgende stand-up en vraag je om hulp.

## 6. Git-workflow

**Branching-strategie**

- We werken met twee vaste branches:
  - `develop`: hierop werken we tijdens de sprint;
  - `main`: alleen werkende code aan het eind van de sprint.
- Voor elk ticket maak je een feature branch vanaf `develop`.
- Pas als de sprint af is, merget de Git-beheerder `develop` naar `main`.

**Werkwijze per ticket**

1. Je pakt een ticket op en maakt een branch vanaf `develop`.
2. Je koppelt de branch aan het ticket (Development → Link branch), zodat het ticket automatisch over het bord beweegt.
3. Je commit en pusht minimaal aan het eind van elke werksessie.
4. Als het ticket af is, open je een pull request naar `develop`.

**Beveiliging van main en develop**

- `main` en `develop` zijn beschermd. Niemand pusht direct op `main` of `develop`, ook de Git-beheerder niet.
- Code komt er alleen in via een goedgekeurde pull request.

**Branchnamen**

- Een nieuwe functie: `feature/<ticketnummer>-<korte-omschrijving>`, bijvoorbeeld `feature/S1-01-database-appdbcontext`.
- Een bugfix: `fix/<ticketnummer>-<korte-omschrijving>`, bijvoorbeeld `fix/S1-07-login-crash`.

**Commitberichten**

- Taal: Nederlands.
- Vorm: `<ticketnummer>: <wat je gedaan hebt>`, bijvoorbeeld `S1-01: Database en AppDbContext aanmaken`.
- Heb je naast het ticket nog iets anders gedaan (bijvoorbeeld een spelfout gefixt), dan zet je dat in de description van de commit.

**Hoe vaak commit en push je?**

- Minimaal aan het eind van **elke werksessie** commit en push je naar je eigen feature branch, ook als het ticket nog niet af is.
- Zo kan iemand anders verder als je afwezig bent.
- De pull request open je pas als het ticket af is.

**Merge conflicts**

- Krijg je een conflict in je eigen feature branch? Dan haal je eerst de laatste `develop` binnen en los je het zelf op.
- Lukt dat niet, dan lost Rowan (Git-beheerder) het samen met jou op, zodat er niets van je werk verloren gaat.

**.gitignore en geheimen**

- We gebruiken de standaard Visual Studio `.gitignore`. Daarin staan onder andere `bin/`, `obj/`, `.vs/` en `*.user`.
- Wachtwoorden, connection strings en API-keys komen **nooit** in de repo.
- Lokale instellingen staan in een bestand dat in `.gitignore` staat, bijvoorbeeld `appsettings.Local.json`.
- In de repo staat een `appsettings.example.json` met lege waarden, zodat iedereen weet wat erin moet.
- Is er per ongeluk een wachtwoord gepusht? Dan meld je dat direct aan Rowan en wijzigen we het wachtwoord.

## 7. Codeafspraken en kwaliteit

**Codeconventies (C# / WinUI 3)**

- **Taal:**
  - Domeinnamen zijn in het Nederlands, zoals in het verhaal van de klant: `Klant`, `Offerte`, `Voorraadmutatie`.
  - Technische delen blijven Engels: `AppDbContext`, `ViewModel`, `Page`, `Service`. Voorbeeld: `KlantViewModel`.
  - Commentaar schrijf je in het Nederlands.
- **Naamgeving:**

| Wat | Stijl | Voorbeeld |
|---|---|---|
| Klassen, methodes, properties | `PascalCase` | `Offerte`, `BerekenTotaal()` |
| Lokale variabelen en parameters | `camelCase` | `klantNaam` |
| Private velden | `_camelCase` | `_dbContext` |
| Interfaces | `I` + `PascalCase` | `IKlantService` |
| Enums | `PascalCase`, enkelvoud | `OfferteStatus`, `Rol` |

**Mappenstructuur en bestandsnamen**

Elk bestand heeft dezelfde naam als de klasse die erin staat (`Klant.cs` bevat `class Klant`), met één klasse per bestand. Nieuwe bestanden zet je in de map die erbij hoort:

```
E3-Barroc-Intens/
├── Assets/
│   ├── Fonts/            → BigShouldersDisplay-*.ttf
│   └── Logo/             → Logo1_groot.png … Logo6_klein.png
├── Data/
│   └── AppDbContext.cs
├── Migrations/           → alleen via EF Core aanmaken, niet met de hand aanpassen
├── Models/               → Klant.cs, Medewerker.cs, Notitie.cs, Offerte.cs,
│   │                       Offerteregel.cs, Product.cs, Voorraadmutatie.cs
│   └── Enums/            → OfferteStatus.cs, Productgroep.cs, Rol.cs
├── ViewModels/           → <Naam>ViewModel.cs, bijv. KlantViewModel.cs
├── Views/                → <Naam>Page.xaml (+ .xaml.cs), bijv. KlantenPage.xaml
├── App.xaml
├── MainWindow.xaml
└── TEAMCONTRACT.md
```

- **Migrations:** een migratie maak je met `Add-Migration <Wat>` in de Package Manager Console, bijvoorbeeld `Add-Migration VoorraadToevoegen`. Je past er zelf niets in aan en verwijdert er geen.
- **Wijzigingen in de database:** wil je de database aanpassen, dan meld je dat eerst in Discord. Zo maken er geen twee mensen tegelijk een migratie.
- **Nieuwe map:** een nieuwe map maak je alleen aan na overleg in de stand-up.

- **Inspringing:** 4 spaties (standaard in Visual Studio), accolades op een nieuwe regel.

**Formatter**

- In de repo staat een `.editorconfig`, zodat iedereen dezelfde opmaak gebruikt.
- Vóór elke commit formatteer je je bestanden met **Ctrl+K, Ctrl+D** in Visual Studio.

**Commentaar en documentatie**

- Je schrijft commentaar als de code niet voor zich spreekt, zoals bij een berekening of een businessregel (bijvoorbeeld de BKR-check of de inkoopgrens van € 5.000).
- Publieke methodes in services krijgen een korte `///`-samenvatting.
- Wijzigingen in de database pas je ook aan in de ERD.

**Tests**

- We schrijven geen geautomatiseerde tests.
- Vóór elke merge test de tester de pull request handmatig aan de hand van de acceptatiecriteria van het ticket.
- De code moet zonder fouten builden, anders wordt er niet gemerged.

## 8. Code reviews en pull requests

- **Goedkeuringen:** een pull request naar `develop` heeft **1 goedkeuring** nodig van iemand anders dan de maker.
- **develop naar main:** de pull request van `develop` naar `main` wordt goedgekeurd door de Git-beheerder (Rowan).
- **Reviewtijd:** binnen **1 schooldag** (24 uur doordeweeks) na het openen van de pull request.
- **Pull request description:** daarin staan het ticketnummer en de acceptatiecriteria van het ticket, met een vinkje bij wat af is.

**Waar let je op tijdens een review?**

- [ ] Werkt het? (zelf uitgeprobeerd)
- [ ] Zijn alle acceptatiecriteria gehaald?
- [ ] Is de code leesbaar en volgt die de conventies uit H7?
- [ ] Staan er geen wachtwoorden of andere geheimen in de code?
- [ ] Buildt de code zonder fouten?

**Feedback geven**

- Je geeft feedback als comment op de regel code zelf.
- Je bent opbouwend en specifiek en hebt het over de code, niet over de persoon. Dus "Deze methode doet twee dingen, kun je hem splitsen?" en niet "Dit is slecht."
- Iets wat moet veranderen, markeer je met **Request changes**.
- Een tip zonder verplichting begin je met "Suggestie:".

**Reviewer afwezig**

- Reageert de reviewer niet binnen 1 schooldag of is die afwezig, dan mag een ander teamlid de review doen.
- Is de Git-beheerder afwezig, dan neemt de Scrum Master de merge van `develop` naar `main` over.

## 9. Conflicten, problemen en consequenties

**Een teamlid aanspreken dat afspraken niet nakomt**

1. **Persoonlijk gesprek:** de Scrum Master (of degene die het probleem merkt) spreekt de persoon binnen 2 schooldagen aan. Samen maken jullie een afspraak met een deadline.
2. **Teamvergadering:** wordt de afspraak niet nagekomen of gebeurt het opnieuw? Dan bespreken we het in de teamvergadering. De notulist zet het in de notulen, met een nieuwe afspraak en deadline.
3. **Gesprek met de docent:** helpt ook dat niet? Dan neemt het Product Owner-contact contact op met de docent. Het team voert samen met het teamlid een gesprek met de docent, op basis van de notulen.
4. **Consequentie:** de docent beslist over een consequentie, bijvoorbeeld een aanpassing van de individuele beoordeling. Het team levert de notulen, de commits en het urenlog aan als onderbouwing.

**Besluiten bij onenigheid**

- Eerst praten we erover, maximaal 10 minuten.
- Daarna stemmen we en beslist de **meerderheid**.
- Bij 2-2 beslist de **Scrum Master**.
- Gaat het over wat de klant wil of over de scope, dan legt het Product Owner-contact de vraag voor aan de docent.
- Elk besluit komt in het besluitendocument.

**Ieders bijdrage zichtbaar maken**

- Iedereen commit onder zijn eigen GitHub-account.
- Elk ticket heeft een assignee.
- Iedereen houdt een **urenlog** bij in de gedeelde map: datum, aantal uren en wat je gedaan hebt. Dat vul je elke week vóór vrijdag in.

**Het contract evalueren**

- We evalueren het contract bij **elke retrospective**, aan het eind van elke sprint.
- Een wijziging gaat via een pull request op `TEAMCONTRACT.md`, die door **alle teamleden** goedgekeurd moet worden.

---

## Afsluiting

Datum: 26-11-2026

| Naam | Akkoord |
|---|---|
| Djay Verlaar | Via goedkeuring van de pull request |
| Sem | Via goedkeuring van de pull request |
| Giovanni van der Weegen | Via goedkeuring van de pull request |
| Rowan de Bont | Via goedkeuring van de pull request |

Je geeft akkoord door de pull request met `TEAMCONTRACT.md` goed te keuren op GitHub.
