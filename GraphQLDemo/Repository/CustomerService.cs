using GraphQLDemo.Models;

namespace GraphQLDemo.Repository
{
    public class CustomerService
    {
        List<Customer> customers = new List<Customer>();
        public CustomerService()
        {
            customers.Add(new
                Customer()
            {
                CustomerId = 1,
                FirstName = "Saeed",
                LastName = "Rezaei",
                Age = 34,
                City = "Ardabil"
            });
            customers.Add(new
              Customer()
            {
                CustomerId = 2,
                FirstName = "Ali",
                LastName = "Joudi",
                Age = 34,
                City = "Tehran"
            });
            customers.Add(new
              Customer()
            {
                CustomerId = 3,
                FirstName = "Mohammad",
                LastName = "Fakhri",
                Age = 30,
                City = "Rasht"
            });
        }

        public List<Customer> GetCustomerList() => customers;
    }
}
