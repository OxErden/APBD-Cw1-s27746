using APBD_Cw1_s27746.Zadanie1.Exceptions;
using APBD_Cw1_s27746.Zadanie1.Model;
using APBD_Cw1_s27746.Zadanie1.Services;

RentalService rentalService = new RentalService();


var studen1 = new Student("oska", "e", 12);
var studen2 = new Student("oskar", "ex", 1213);
var laptop = new Laptop("asus", "sony", 1,15);
var camera = new Camera("d", "de", 1,2);
var projector = new Projector("e", "x", "4k", 5000);


try
{

    rentalService.AddRental(studen1, laptop, new DateTime(2020, 01, 01), new DateTime(2020, 01, 31));
    rentalService.AddRental(studen2, camera, new DateTime(2020, 01, 01), new DateTime(2027, 01, 31));
    rentalService.AddRental(studen1, projector, new DateTime(2020, 01, 01), new DateTime(2020, 01, 31));
}
catch (EquipmentNotAvailableException e)
{
    Console.WriteLine(e.Message);
}



foreach (var rental in rentalService.GetAllRentals())
{
    Console.WriteLine(rental);
}

rentalService.ReturnRental(studen1, laptop);

Console.Write("------------------------------------- \n");

foreach (var rental in rentalService.GetAllRentals())
{
    Console.WriteLine(rental);
}


Console.Write("------------------------------------- \n");


var overdueRentals = rentalService.GetOverdueRentals();

if (overdueRentals.Count == 0)
{
    Console.WriteLine("Brak przeterminowanych wypożyczeń.");
}
else
{
    Console.WriteLine("\n--- Przeterminowane wypożyczenia ---");
    foreach (var rental in overdueRentals)
    {
        Console.WriteLine(rental);
    }
}