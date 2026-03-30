using APBD_Cw1_s27746.Zadanie1.Exceptions;
using APBD_Cw1_s27746.Zadanie1.Model;

namespace APBD_Cw1_s27746.Zadanie1.Services;

public class RentalService : IRentalService
{
    
    private List<Rental> rentals = new List<Rental>();
    private static int delayFeePerDay = 10;

    
    public void AddRental(User user, Equipment equipment, DateTime rentalStart, DateTime rentalEnd)
    {

        try
        {
            if (!equipment.isAvailable)
            {
                throw new EquipmentNotAvailableException(equipment.equipmentid);
            }

            int activeUserReservations = rentals.Count(rental => rental.user == user && !rental.isReturned);

            if (activeUserReservations >= user.MaxActiveRentals)
            {
                throw new UserRentalLimitExceededException(user.userid);
            }

            var rental = new Rental(user, equipment, rentalStart, rentalEnd);
            equipment.isAvailable = false;
            rentals.Add(rental);
        }
        catch (EquipmentNotAvailableException ex)
        {
            Console.WriteLine(ex.Message);
        }catch (UserRentalLimitExceededException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void ReturnRental(User user, Equipment equipment)
    {
        
        var rental = rentals.FirstOrDefault(rental => rental.user == user && rental.equipment == equipment && !rental.isReturned);
        {
            if (rental is null)
            {
                throw new RentalNotFoundException(equipment.equipmentid, user.userid);
            }
        }
        
        rental.isReturned = true;
        rental.realRentalEnd = DateTime.Now;
        equipment.isAvailable = true;
        rentals.Remove(rental);

        if (rental.realRentalEnd >= rental.rentalEnd)
        {
            int delayDays = (rental.realRentalEnd.Value - rental.rentalEnd).Days;
            rental.totalDelayFee = delayDays * delayFeePerDay;
        }
        
    }

    public List<Rental> GetUserRentals(User user)
    {
        return rentals.Where(rental => rental.user == user && !rental.isReturned).ToList();
    }

    public List<Rental> GetOverdueRentals()
    {
        return rentals.Where(rental => !rental.isReturned && rental.rentalEnd < DateTime.Now).ToList();
    }

    public List<Rental> GetAllRentals()
    {
        return rentals;
    }
    
}

    