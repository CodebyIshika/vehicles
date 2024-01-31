using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLab03
{
    public abstract class RentalTransaction
    {
        public int TransactionId { get; set; }
        public DateTime RentalStartDate { get; set; }
        public DateTime RentalEndDate { get; set; }

        // constructor
        protected RentalTransaction(int transactionId, DateTime rentalStartDate, DateTime rentalEndDate)
        {
            this.TransactionId = transactionId;
            this.RentalStartDate = rentalStartDate;
            this.RentalEndDate = rentalEndDate;
        }

        // This is abstract method that is going to be implemented by derived classes
        public abstract double CalculateRentalCost();

    }
}
