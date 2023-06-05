namespace Demo_EFC_01.Models
{
    public enum StudentGender
    {
        F, M, X
    }

    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Email { get; set; }
        public int? PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsValidate { get; set; }
        public StudentGender Gender { get; set; }
        public int RegNat { get; set; }
    }
}
