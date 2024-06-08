namespace Models
{
    public class Person
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public Gender? Gender { get; set; }
        public string? Address { get; set; }
        public Town? Town { get; set; }
        public Country? Country { get; set; }
        public Occupation? Occupation { get; set; }
        public PoliticalOrientation? PoliticalOrientation { get; set; }
        public string? Religion { get; set; }
        public string? EducationLevel { get; set; }
    }
}