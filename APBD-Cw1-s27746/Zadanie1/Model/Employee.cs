namespace APBD_Cw1_s27746.Zadanie1.Model;

public class Employee(string name, string surname, string department) : User (name, surname)

{
    public string Department { get; set; } =  department;


    public override int MaxActiveRentals => 5;
}