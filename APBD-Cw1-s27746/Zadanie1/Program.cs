


using APBD_Cw1_s27746.Zadanie1.Model;

var laptop1 = new Laptop("DellXHP", "Dell", 256, 16);
var laptop2 = new Laptop("ZBook ","HP", 128, 15);
var laptop3 = new Laptop("Nitro 5", "Asus", 512, 17);
var projektor1 = new Projector("SonyX3", "Sony", "4kULTRAHD", 5000);
var projektor2 = new Projector("SonyX5", "Sony", "8kULTRAHD", 6000);
var camera1 = new Camera("IXUS 500", "Canon", 500, 2100);

var studen1 = new Student("Oskar", "Erdenberger", 27746);
var studen2 = new Student("Patyk", "Fijalkoswi", 25789);
var studen3 = new Student("Hela", "Chymel", 27312);


List<Equipment> equipments = new List<Equipment>();
equipments.Add(projektor1);
equipments.Add(projektor2);
equipments.Add(laptop1);
equipments.Add(laptop2);
equipments.Add(laptop3);
equipments.Add(camera1);

foreach (var equipment in equipments)
{
    Console.WriteLine(equipment.getDetails());
}


Console.WriteLine("----------------------------");


var rental1 = new Rental(studen1, laptop1, DateTime.Now, DateTime.Now.AddDays(7));
var rental2 = new Rental(studen2, camera1,DateTime.Now, DateTime.Now.AddDays(7));
var rental3 = new Rental(studen3, camera1,DateTime.Now, DateTime.Now.AddDays(7));

foreach (var equipment in equipments)
{
    Console.WriteLine(equipment.getDetails());
}




foreach (var equipment in equipments)
{
    if (!equipment.isAvailable)
    {
        Console.WriteLine(equipment.getDetails());
    }
}