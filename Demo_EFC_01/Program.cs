using Demo_EFC_01.Database;
using Demo_EFC_01.Models;
using System.Globalization;

// Utilisation de la DB via EFC
using (AppDbContext db = new AppDbContext())
{
    Console.WriteLine("Liste des étudiants : ");
    foreach (Student st in db.Students)
    {
        Console.WriteLine($" - {st.StudentId} {st.FirstName} {st.LastName}");
    }
    Console.WriteLine();


    Console.WriteLine("Ajout d'un étudiant : ");
    // Ajout en mode bourin dans la console ♥
    Console.Write(" Prenom : ");
    string firstName = Console.ReadLine();
    Console.Write(" Nom : ");
    string lastName = Console.ReadLine();
    Console.Write(" DateNaissance (dd-mm-yyyy) : ");
    string birthDateStr = Console.ReadLine();
    DateTime birthDate = DateTime.ParseExact(birthDateStr, "dd-MM-yyyy", CultureInfo.InvariantCulture);
    Console.Write(" Email : ");
    string email = Console.ReadLine();
    Console.Write(" Sexe (F/M/X) : ");
    StudentGender gender = (StudentGender)Enum.Parse(typeof(StudentGender), Console.ReadLine());
    Console.Write(" Registre national : ");
    long regNat = long.Parse(Console.ReadLine());

    db.Students.Add(new Student
    {
        StudentId = 3,
        FirstName = firstName,
        LastName = lastName,
        BirthDate = birthDate,
        Email = email,
        Gender = gender,
        IsValidate = true,
        RegNat = regNat
    });
    db.SaveChanges();
    Console.WriteLine($" -> Ajout de {firstName} !");
    Console.WriteLine();

    Console.WriteLine("Liste des étudiants : ");
    foreach (Student st in db.Students)
    {
        Console.WriteLine($" - {st.StudentId} {st.FirstName} {st.LastName}");
    }
}