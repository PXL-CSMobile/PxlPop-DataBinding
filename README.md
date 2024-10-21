# PxlPop

## Intro
Nu de navigatie via een flyout en tabs verloopt is het tijd om wat functionaliteit aan deze applicatie toe te voegen!

## Data Binding

### TicketPage

#### Aantal
- Maak in het code-behind bestand van de *TicketPage* 5 properties:
	- int StaDayTickets
	- int VipDayTickets
	- int StaCombiTickets
	- int VipCombiTickets
	- int NumberOfDays
- Zorg dat deze properties via data binding gekoppeld zijn aan de bijhorende *Entry* controls en de *Picker* control
- Zorg er als laatste voor dat wanneer de waarde van één van deze properties wijzigt deze ook getoond wordt in de UI 
	>Tip: INotifyPropertyChanged
- Stel de *BindingContext* van de *TicketPage* in door ```this.BindingContext = this;``` toe te voegen aan de constructor

#### Commands
- Maak voor elke min- en plusknop een property van het type ICommand aan
- Zorg dat deze commands geïnitialiseerd worden in de constructor van de *TicketPage*
- Wijs elk command toe via binding aan de bijhorende knop via het *Command* attribuut
- Zorg dat de juiste property verminderd/vermeerderd wordt met 1 wanneer een commando uitgevoerd wordt

#### Bedrag
- Maak een nieuwe readonly property: ```public int TotalAmount { get; }```
- Zorg dat deze property het totaalbedrag retourneert op basis van het aantal geselecteerde tickets (en dagen). Hanteer de volgende prijzen:
	- Een standaard dagticket : € 60 
	- Een VIP dagticket : € 130 
	- Een standaard combiticket : € 50 / dag
	- Een VIP combiticket : € 110 / dag
- Wijzig de tekst van de bestelknop zodat het totaalbedrag van de bestelling getoond wordt. Gebruik hiervoor opnieuw data binding en zorg dat het bedrag in het juiste formaat getoond wordt
- Zorg er nu voor dat ook de waarde van deze property geupdate wordt in de UI wanneer het aantal tickets (of dagen) wijzigt.

### Order
- Refactor bovenstaande en verplaats alle properties naar een aparte klasse *Order* in de *Models* namespace

## Extra
- Zorg ervoor dat een gebruiker nooit meer dan 8 tickets kan bestellen.
> Tip: [CanExecute](https://learn.microsoft.com/en-us/dotnet/maui/fundamentals/data-binding/commanding?view=net-maui-8.0)