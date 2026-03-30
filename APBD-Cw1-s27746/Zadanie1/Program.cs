
using APBD_Cw1_s27746.Zadanie1.Model;
using APBD_Cw1_s27746.Zadanie1.Services;
//tworzenie sprzętu
var laptop1 = new Laptop("nitro5", "Asus", 512, 17);
var laptop2 = new Laptop("ZBook", "HP", 256, 15 );
var projector1 = new Projector("prx5", "Sony", "4kUltraHd",5000);
var camera1 = new Camera("Canon 5000", "Canon", 500, 1850);
//tworzenie uzytkowników
var student1 = new Student("John", "Murphy", 3332);
var student2 = new Student("Clarke", "Griffin", 1123);
var student3 = new Student("Bellamy", "Blake", 2215);
var employee1 = new Employee("Marcus","Kane","Security");


RentalService rentalService = new RentalService();

//poprawne wypozyczenie 
rentalService.AddRental(student2, laptop1, new DateTime(2026,03,25),new DateTime(2026,03,31));

Console.Write("\n ------------LISTA PO POPRAWNEJ PRÓBIE WYPOZYCZENIA-----------------");
foreach (var rental in rentalService.GetAllRentals())
{
    Console.Write("\n" +rental);
}

//niepoprawna operacja - wypożyczenie niedostępnego sprzętu
Console.Write("\n ------------PRÓBA WYPOŻYCZENIA NIEDOSTĘPNEGO SPRZĘTU-----------------");
rentalService.AddRental(student1,laptop1,DateTime.Now,new DateTime(2026,04,05));



Console.Write("\n ------------LISTA PO NIEPOPRAWNEJ PRÓBIE WYPOZYCZENIA-----------------");
foreach (var rental in rentalService.GetAllRentals())
{
    Console.Write("\n" +rental);
}


//zwrot sprzętu w terminie
Console.Write("\n ------------ZWROT SPRZĘTU W TERMINIE-----------------");
rentalService.ReturnRental(student2,laptop1);

foreach (var rental in rentalService.GetAllRentals())
{
    Console.Write("\n" +rental);
}
//zwrot sprzętu po terminie

Console.Write("\n ------------ZWROT SPZĘTU PO TERMINIE-----------------");

rentalService.AddRental(student3,laptop1,new DateTime(2026,03,06),new DateTime(2026,03,15));
rentalService.ReturnRental(student3,laptop1);