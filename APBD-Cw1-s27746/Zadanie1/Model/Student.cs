namespace APBD_Cw1_s27746.Zadanie1.Model;

public class Student(string name, string surname, int studentnumber) : User(name, surname)

{
public int Studentnumber { get; set; } = studentnumber;



}