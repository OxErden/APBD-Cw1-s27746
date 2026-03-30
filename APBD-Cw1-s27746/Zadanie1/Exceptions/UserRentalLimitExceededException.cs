namespace APBD_Cw1_s27746.Zadanie1.Exceptions;

public class UserRentalLimitExceededException : Exception
{
    public UserRentalLimitExceededException(int userid) : base($"UserID {userid} exceeded the maximum allowed rental limit")
    {
        
    }
    
}