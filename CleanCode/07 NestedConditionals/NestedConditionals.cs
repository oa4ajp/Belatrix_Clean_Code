using System;

namespace CleanCode.NestedConditionals
{
    public class Customer
    {
        public int LoyaltyPoints { get; set; }
    }

    public class Reservation
    {
        public Reservation(Customer customer, DateTime startDate)
        {
            FromDate = startDate;
            Customer = customer;
        }

        public DateTime FromDate { get; set; }
        public Customer Customer { get; set; }
        public bool IsReservationCanceled { get; set; }

        public void CancelReservation()
        {
            // If reservation already started throw exception
            if (DateTime.Now > FromDate)
            {
                throw new InvalidOperationException("It's too late to cancel.");
            }
            ValidateCustomerLoyaltyPoints();
            IsReservationCanceled = true;
        }

        public void ValidateTotalHours(int maxHours) {
            if ((FromDate - DateTime.Now).TotalHours < maxHours)
            {
                throw new InvalidOperationException("It's too late to cancel.");
            }
        }

        public void ValidateCustomerLoyaltyPoints()
        {            
            if (Customer.LoyaltyPoints > 100)
            {
                // Gold customers can cancel up to 24 hours before
                ValidateTotalHours(24);
            }
            else
            {
                // Regular customers can cancel up to 48 hours before      
                ValidateTotalHours(48);
            }
        }

    }
}
