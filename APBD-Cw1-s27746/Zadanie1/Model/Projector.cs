namespace APBD_Cw1_s27746.Zadanie1.Model;

public class Projector (string equipmentname, string equipmentmanufacturer, string resoultion, int lumens) : Equipment(equipmentname,equipmentmanufacturer) 
{
    
    public string resolution {get; set;} = resoultion;
    public int lumens { get; set; } = lumens;
    
    public override string getDetails()
    {
        return $"PROJECTOR, EQUIPMENT ID: {equipmentid}, Name: {equipmentname}, Brand: {equipmentmanufacturer }, Resolution : {resolution}, Lumens: {lumens}, availability: {isAvailable}" ;
    }

    
}