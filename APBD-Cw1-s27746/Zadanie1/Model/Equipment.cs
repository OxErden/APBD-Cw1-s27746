namespace APBD_Cw1_s27746.Zadanie1.Model;

public abstract class Equipment(string equipmentname, string equipemtnmanufacturer)
{   
    private static int _id = 0;
    
    public int equipmentid { get; } = ++_id;
    public string equipmentname { get; } = equipmentname;
    public string equipmentmanufacturer  { get; } = equipemtnmanufacturer;
    
    public bool isAvailable { get; set; } = true;


    public abstract string getDetails();
}