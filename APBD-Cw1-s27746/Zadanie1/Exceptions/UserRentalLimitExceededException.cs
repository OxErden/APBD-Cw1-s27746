namespace APBD_Cw1_s27746.Zadanie1.Exceptions;

public class UserRentalLimitExceededException : Exception
{
    public UserRentalLimitExceededException(string username)
    {
        Console.WriteLine($"User {username} exceeded the maximum allowed rental limit");
    }
    
}