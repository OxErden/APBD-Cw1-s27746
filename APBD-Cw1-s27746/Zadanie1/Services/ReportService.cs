using APBD_Cw1_s27746.Zadanie1.Model;

namespace APBD_Cw1_s27746.Zadanie1.Services;

public class ReportService : IReportService
{
    
    private readonly RentalService _rentalService;
    private readonly EquipmentService _equipmentService;
    public ReportService(RentalService rental, EquipmentService equipmentService)
    {
        _rentalService = rental;
        _equipmentService = equipmentService; 
    }

    public void GenerateReport()
    {
        var allRentals = _rentalService.GetAllRentals();
        var  allEquipments = _equipmentService.GetAllEquipments();
        var availableEquipments = _equipmentService.GetAvailableEquipments();

        Console.WriteLine("\n==========================================");
        Console.WriteLine("       RAPORT STANU WYPOŻYCZALNI        ");
        Console.WriteLine("==========================================");
        Console.WriteLine($" = All rentals amount: {allRentals.Count}" );
        Console.WriteLine($" = Total equipment number: {allEquipments.Count}");
        Console.WriteLine($" = Available equipment : {availableEquipments.Count}");

    }
}