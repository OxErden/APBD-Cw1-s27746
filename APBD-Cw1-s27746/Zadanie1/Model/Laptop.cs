namespace APBD_Cw1_s27746.Zadanie1.Model;

public class Laptop (string equipmentname, string equipemtnmanufacturer, int storage, int screenDimInInch): Equipment(equipmentname, equipemtnmanufacturer)
{

    public int storage { get; set; } = storage;
    public int screenDimInInch { get; set; } = screenDimInInch;
    
    
    public override string getDetails()
    {
        return $"LAPTOP, EQUIPMENT ID: {equipmentid}, Name: {equipmentname}, Brand: {equipemtnmanufacturer}, Screen Size: {screenDimInInch}, availability: {isAvailable}" ;
    }

}


