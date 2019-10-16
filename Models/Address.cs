namespace WebAPIStarter.Data.Models
{
    public class Address
    {
        public long Id { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string StateProvice { get; set; }
        public string Zipcode { get; set; }
    }
}