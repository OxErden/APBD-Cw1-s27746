

using System.Collections;
using APBD_Cw1_s27746.Zadanie1.Model;

var student1 = new Student("oskar", "x", 27746);
var student2 = new Student("lukasz", "z", 23565);

var employee1 = new Employee("kacper", "W", "HR");
var employee2 = new Employee("maksymilian", "C", "UX");
var employee3 = new Employee("sylwia", "G", "Marketing");


List<Student> students = new List<Student>();

students.Add(student1);
students.Add(student2);

List<Employee> employees = new List<Employee>();
employees.Add(employee1);
employees.Add(employee2);
employees.Add(employee3);

int counter = 1;
foreach (var employee in employees)
{
    
    Console.WriteLine($"{"Employee nr: " + counter++} {employee.name} {employee.surname} {employee.Department}");
}

student1.username = "oxerden";

foreach (var student in students)
{
    Console.WriteLine($"{student.name} {student.surname} {student.username} {"STUDENT NUMBER: " + student.Studentnumber}");
}


