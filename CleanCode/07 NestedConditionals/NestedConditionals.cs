using System;

namespace CleanCode.NestedConditionals
{
    public class Customer
    {
        public int LoyaltyPoints { get; set; }
    }

    public class Reservation
    {
        public DateTime FromDate { get; set; }
        public Customer Customer { get; set; }
        public bool IsReservationCanceled { get; set; }

        public int maxTotalHoursForGoldCustomer = 24;
        public int maxTotalHoursForRegularCustomer = 48;
        public int maxLoyaltyPoint = 100;

        public Reservation(Customer customer, DateTime startDate)
        {
            FromDate = startDate;
            Customer = customer;
        }

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
            if (Customer.LoyaltyPoints > maxLoyaltyPoint)
            {
                // Gold customers can cancel up to 24 hours before
                ValidateTotalHours(maxTotalHoursForGoldCustomer);
            }
            else
            {
                // Regular customers can cancel up to 48 hours before      
                ValidateTotalHours(maxTotalHoursForRegularCustomer);
            }
        }
    }
}
