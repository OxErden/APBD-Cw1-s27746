using APBD_Cw1_s27746.Zadanie1.Model;

namespace APBD_Cw1_s27746.Zadanie1.Services;

public interface IEquipmentService
{
    public void AddEquipment(Equipment equipment);
    public void DeleteEquipment(Equipment equipment);
    public List<Equipment> GetAllEquipments();
    public List<Equipment> GetAvailableEquipments();
}