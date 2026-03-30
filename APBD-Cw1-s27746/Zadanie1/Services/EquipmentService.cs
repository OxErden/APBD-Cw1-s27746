using APBD_Cw1_s27746.Zadanie1.Model;

namespace APBD_Cw1_s27746.Zadanie1.Services;

public class EquipmentService : IEquipmentService
{
    
    private List<Equipment> equipments = new List<Equipment>();
    
    public void AddEquipment(Equipment equipment)
    {
        equipments.Add(equipment);
    }

    public void DeleteEquipment(Equipment equipment)
    {
        equipments.Remove(equipment);
    }

    public List<Equipment> GetAllEquipments()
    {
        return  equipments.ToList();
    }

    public List<Equipment> GetAvailableEquipments()
    {
        return  equipments.ToList().Where(e => e.isAvailable).ToList();
    }
}