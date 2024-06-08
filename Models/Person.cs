namespace Models
{
    public class Person
    {
        public Name? Name { get; set; }
        public DateOnly Birthday { get; set; }
        public Ethnicity? Ethnicity { get; set; }
        public Gender? Gender { get; set; }
        public SexualOrientation? SexualOrientation { get; set; }
        public Address? Address { get; set; }
        public Occupation? Occupation { get; set; }
        public PoliticalOrientation? PoliticalOrientation { get; set; }
        public Religion? Religion { get; set; }
        public EducationalAttainment? EducationalAttainment { get; set; }
        public HealthStatus? HealthStatus { get; set; }
    }
}