namespace WebAPIStarter.Data.Models
{
    public class CustomerAddress
    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public long AddressId { get; set; }
        public Address Address { get; set; }
    }
}