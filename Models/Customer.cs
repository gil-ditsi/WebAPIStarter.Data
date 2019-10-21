using System.Collections.Generic;

namespace WebAPIStarter.Data.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public IList<CustomerAddress> CustomerAddresses { get; set; }
    }
}