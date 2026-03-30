namespace APBD_Cw1_s27746.Zadanie1.Model;

public class Camera(string equipmentname, string equipmentmanufacturer, int memory, int matrixPx) : Equipment(equipmentname, equipmentmanufacturer)
{


    public int memory { get; set; } = memory;
    public int matrixPx { get; set; } = matrixPx;
    
    public override string getDetails()
    {
        return $"CAMERA, EQUIPMENT ID: {equipmentid}, Name: {equipmentname}, Brand: {equipemtnmanufacturer}, Memory: {memory}, MatrixPx: {matrixPx}, availability: {isAvailable}" ;
    }
}