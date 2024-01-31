using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLab03
{
    public class TruckRental : RentalTransaction
    {
        public string CustomerName { get; set; }
        public DateTime ActualReturnDate { get; set; }

        // constructor
        public TruckRental(int transactionId, DateTime rentalStartDate, DateTime rentalEndDate, string customerName)
            : base(transactionId, rentalStartDate, rentalEndDate)
        {
            CustomerName = customerName;
        }
        

        public override double CalculateRentalCost()
        {
            // for calculating rent of truck
            // first we will calculate number of days for which truck is rented is going to total days multiplied by 
            // difference of return date and start date = (ActualReturnDate - RentalStartDate).TotalDays
            int totalRentalDays = (int)(ActualReturnDate - RentalStartDate).TotalDays;

            // then according to requirement we will set the cost of renting per day
            double dailyRent = 100.0;

            // last total cost is find by multiplying the number of rented days by the daily cost
            double totalCostOfRent = totalRentalDays * dailyRent;

            return totalCostOfRent;
        }
    }
}
