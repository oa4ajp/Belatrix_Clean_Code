using CleanCode._10_Comments;
using System.Collections.Generic;

namespace CleanCode.Comments
{
    public class Comments
    {
        private OrderService _orderService;
        private CustomerService _customerService;

        public Comments()
        {
            _orderService = new OrderService();
            _customerService = new CustomerService();
        }

        public List<Customer> GetCustomers(int countryCode)
        {
            return _customerService.GetCustomers(countryCode);
        }

        public void SubmitOrder(Order order)
        {
            _orderService.SubmitOrder(order);
        }

    }

    public class DbContext
    {
        public DbSet<Order> Orders { get; set; }

        public void SaveChanges()
        {
        }
    }

    public class DbSet<T>
    {
        public void Add(Order order)
        {
        }
    }
    public class Order
    {
        public Customer Customer { get; set; }
    }

    public class Customer
    {
        public string Email { get; set; }
    }
}
