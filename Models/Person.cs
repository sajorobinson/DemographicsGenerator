namespace DemographicsGenerator.Models
{
    public class Person
    {
        public Name? Name { get; set; }
        public DateOnly Birthday { get; set; }
        public Gender? Gender { get; set; }
        public SexualOrientation? SexualOrientation { get; set; }
        public Ethnicity? Ethnicity { get; set; }
        public EducationalAttainment? EducationalAttainment { get; set; }
        public Occupation? Occupation { get; set; }
        public Hobby? Hobby { get; set; }
        public HealthStatus? HealthStatus { get; set; }
        public Religion? Religion { get; set; }
        public PoliticalOrientation? PoliticalOrientation { get; set; }
        public Address? Address { get; set; }
    }
}