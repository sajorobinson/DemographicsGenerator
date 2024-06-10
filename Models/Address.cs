namespace Models
{
    public class Address
    {
        public string Street { get; set; } = "123 Fake Street";
        public Town? Town { get; set; }
    }
}