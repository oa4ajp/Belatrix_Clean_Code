using CleanCode.NestedConditionals;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CleanCode.UnitTests
{
    [TestClass]
    public class CancelReservationTests
    {
        [TestMethod]
        public void GoldCustomer_CancellingMoreThan24Hours_ShouldCancel()
        {
            var customer = CreateGoldCustomer();
            var reservation = new Reservation(customer, DateTime.Now.AddHours(25));

            reservation.CancelReservation();

            Assert.IsTrue(reservation.IsReservationCanceled);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void GoldCustomer_CancellingLessThan24HoursBefore_ShouldThrowException()
        {
            var customer = CreateGoldCustomer();
            var reservation = new Reservation(customer, DateTime.Now.AddHours(23));

            reservation.CancelReservation();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void GoldCustomer_CancellingAfterStartDate_ShouldThrowException()
        {
            var customer = CreateGoldCustomer();
            var reservation = new Reservation(customer, DateTime.Now.AddDays(-1));

            reservation.CancelReservation();
        }

        [TestMethod]
        public void RegularCustomer_CancellingMoreThan48HoursBefore_ShouldCancel()
        {
            var customer = CreateRegularCustomer();
            var reservation = new Reservation(customer, DateTime.Now.AddHours(49));

            reservation.CancelReservation();

            Assert.IsTrue(reservation.IsReservationCanceled);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void RegularCustomer_CancellingLessThan48Hours_ShouldThrowException()
        {
            var customer = CreateRegularCustomer();
            var reservation = new Reservation(customer, DateTime.Now.AddHours(47));

            reservation.CancelReservation();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void RegularCustomer_CancellingAfterStartDate_ShouldThrowException()
        {
            var customer = CreateRegularCustomer();
            var reservation = new Reservation(customer, DateTime.Now.AddHours(-1));

            reservation.CancelReservation();
        }

        private static Customer CreateGoldCustomer()
        {
            return new Customer { LoyaltyPoints = 200 };
        }

        private static Customer CreateRegularCustomer()
        {
            return new Customer();
        }
    }
}
