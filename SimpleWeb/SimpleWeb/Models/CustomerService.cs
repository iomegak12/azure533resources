using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleWeb.Models
{
    public class CustomerService
    {
        public IEnumerable<Customer> GetCustomers()
        {
            var random = new Random();
            var address = "Bangalore";
            var customersList = new List<Customer>(
                from index in Enumerable.Range(1, 20)
                select new Customer
                {
                    Id = index,
                    Name = Guid.NewGuid().ToString(),
                    Address = address,
                    Credit = random.Next(20000, 50000),
                    Status = index % 2 == 0
                });

            return customersList;
        }
    }
}