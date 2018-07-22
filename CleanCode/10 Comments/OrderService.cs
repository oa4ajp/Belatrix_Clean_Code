using CleanCode.Comments;

namespace CleanCode._10_Comments
{
    public class OrderService
    {
        private DbContext _dbContext;
        private MailService _mailService;

        public OrderService()
        {
            _dbContext = new DbContext();
            _mailService = new MailService();
        }

        public void SubmitOrder(Order order)
        {
            // Save order to the database
            _dbContext.Orders.Add(order);
            _dbContext.SaveChanges();

            _mailService.SendEmailToCustomer(order.Customer.Email);
        }
    }
}
