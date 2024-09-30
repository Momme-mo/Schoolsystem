using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Schoolsystem;

class Program
{
    static void Main(string[] args)
    {
        /* Objekt av klassen "Students" */
        List<Students> student = new List<Students>();

        //Lägg till ny student...
        Console.WriteLine("Skriv Student ID:");
        int id = int.Parse(Console.ReadLine());
        Console.WriteLine("Skriv in elev namn:");
        string firstname = Console.ReadLine();
        Console.WriteLine("Skriv elevens efternamn:");
        string lastname = Console.ReadLine();

        student.Add(new Students(id, firstname, lastname));

        Console.WriteLine("Lista av Studenter:");
        foreach (var Students in student)
        {
            Console.WriteLine($"Elev: {id} {firstname} {lastname}");
        }

        /* Objekt av klassen "Courses" */
        var courses = new Courses();
        Console.WriteLine(courses.ToString());

        /* Objekt av klassen "Teachers" */
        var teachers = new Teachers();
        Console.WriteLine(teachers.ToString());

        /* Objekt av klassen "Leader" */
        var leader = new Leader();
        Console.WriteLine(leader.ToString());

    }
}
