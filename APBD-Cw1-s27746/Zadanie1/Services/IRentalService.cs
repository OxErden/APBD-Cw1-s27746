using APBD_Cw1_s27746.Zadanie1.Model;

namespace APBD_Cw1_s27746.Zadanie1.Services;

public interface IRentalService
{
    public void AddRental(User user, Equipment equipment, DateTime rentalStart, DateTime rentalEnd);
    public void ReturnRental(User user, Equipment equipment);
    public List<Rental> GetUserRentals(User user);
    public List<Rental> GetOverdueRentals();

    public List<Rental> GetAllRentals();
}