Hallo hier is een kleine readme met alle mogelijkheden en features die bestaan in deze app.


- Sign-in + log-in 
  
→ 


User dashboard (voor logopedist)

→ 3 tabellen met zicht op alle details
→ mogelijkheid om elementen vanuit de dashboard  aan te maken
→ op een cel klikken brengt naar het " profiel " van dat specifiek element. ( profiel patient , profiel van test , profiel van een mutualiteit)
→ menustrip met bepaalde mogelijkheden, zoals het uitloggen, het aanmaken van nieuwe elementen, of het refreshen van de pagina. 


profiel van een patient:

→ tab-systeem met verschillende elementen : → overzicht van de gegevens van een patient
                                            → sessie manager voor het toevoegen of verwijderen van sessies, bij de verwijdering die de teller op nul zal zetten , 
                                              wordt de logopedist gewaarschuwd en word box om te verwijderen onbruikbaar tot er weer sessies toegevoegd wordt. 

→ button om naar de wizard te gaan voor het aanpassen van een patient zijn gegevens 
→ button om deze patient definitief te verwijderen, er wordt wel eerst een bevestiging gevraagd. 
→ tests manager : er kunnen BESTAANDE tests toegevoegd worden in de lijst van de persoon zelf, deze lijst is uniek per patient. 


profiel van een test of van een mutualiteit

→ details bekijken in een "profiel scherm van het gekozen element door op de dashboard een element aan te klikken
→ element aanpassen
→ element verwijderen
→ beiden hebben een lijst: voor de tests is dit een lijst van alle patienten die deze test hebben afgelegd voor de mutualiteit is dit een lijst van alle patienten die bij deze geafilieerd zijn


Algemene zaken:

→ volledige controle over het maken van een nieuw element ( patient , test , enz.) er kan bv niet een geboortedatum in de toekomst gekozen worden. 
→ controle voor het verwijderen: bv: patienten die hun mutualiteit zien verwijderd worden , zullen ook deze op null hebben totdat de logopedist,
                                 door het aanpassen van de patient, een nieuwe mutualiteit toevoegd aan deze.
                                 
→ Online azure database dus geen problemen voor de toegang tot data in combinatie met Linq en lambda expressies 

gebruikte "nieuwe technologien":

→ Entity framework voor het werken met de database ( aanmaken nieuwe elementen, ophalen , verwijderen , aanpassen)
→ microsoft azure voor de database 

Bronnen:

→ microsoft azure documentatie 
→ microsoft C#/.net documentatie 
→ canvas 
→ Microsoft Entity framework documentatie 