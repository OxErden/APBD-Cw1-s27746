namespace APBD_Cw1_s27746.Zadanie1.Model;

public class Rental
{
    
    private static int _id = 0;
    private static int delayFeePerDay = 10;
    
    public int rentalId { get; }
    
    public DateTime rentalStart { get; } 
    public DateTime rentalEnd { get; set; } 
    public DateTime realRentalEnd { get; set; }
    public User user { get; set; } 
    public Equipment equipment { get; set; } 
    public bool isReturned { get; set; } = false;
    public int totalDelayFee { get; set; }

    public Rental(User user, Equipment equipment, DateTime rentalStart, DateTime rentalEnd)
    {
        
        
        this.user = user;
        this.equipment = equipment;
        this.rentalStart = rentalStart;
        this.rentalEnd = rentalEnd;
        this.rentalId = ++_id;
        equipment.isAvailable = false;
        
    }

    public void Return()
    {
        isReturned = true;
        realRentalEnd = DateTime.Now;
        equipment.isAvailable = true;

        if (realRentalEnd > rentalEnd)
        {
            int delayDays = (realRentalEnd - rentalEnd).Days;
            totalDelayFee = delayDays * delayFeePerDay;
        }
        else
        {
            totalDelayFee = 0;
        }
    }

}