Instrukcja uruchomienia:

Otwórz terminal w katalogu projektu.
Skompiluj projekt:

    dotnet build

Uruchom aplikację:

    dotnet run


Opis i struktura projektu:
"Uczelniana wypożyczalnia sprzętu"

Podział warstw
Kod podzieliłem na trzy warstwy: model domenowy, serwisy i wyjątki.
Model zawiera tylko dane i ich reprezentację - klasy takie jak 'Rental'
czy 'Equipment' nie zawierają logiki biznesowej. Całą logikę przeniosłem
do serwisów, dzięki czemu zmiana reguły biznesowej wymaga modyfikacji tylko jednego miejsca w kodzie.

Każda klasa ma jedną odpowiedzialność, robi tylko rzeczy z nią związane:
- 'RentalService' – zarządza wypożyczeniami i ich regułami
- 'EquipmentService' – zarządza sprzętem
- 'ReportService' – generuje raporty na podstawie danych z innych serwisów

Używam własnych wyjątków które sa łapane wewnątrz serwisów i wyświetlają czytelny komunikat
