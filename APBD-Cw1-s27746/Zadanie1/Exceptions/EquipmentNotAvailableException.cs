namespace APBD_Cw1_s27746.Zadanie1.Exceptions;

public class EquipmentNotAvailableException : Exception
{
    public EquipmentNotAvailableException(int equipmentId) : base($"\n Equipment ID: {equipmentId} is not available for rent")
    {
        
    }

}