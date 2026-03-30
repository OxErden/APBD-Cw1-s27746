namespace APBD_Cw1_s27746.Zadanie1.Exceptions;

public class RentalNotFoundException : Exception
{
    public RentalNotFoundException(int equipmentid, int userid) :  base($"\n Rental for equipment {equipmentid} by username: {userid} not found")
    {
    }
    

}