namespace APBD_Cw1_s27746.Zadanie1.Model;

public abstract class User(string name, string surname)
{
    
    private static int _id = 0;
    public string name { get; set; } = name;
    public string surname { get; set; } = surname;
    public string username { get; set; }
    public int userid { get; } =  ++_id;

    public abstract int MaxActiveRentals { get; }
    
}