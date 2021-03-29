using System;

namespace Patterns.SOLID.InterfaceSegregationPrinciple.ISPInterfaces
{
    public interface IBorrowable
    {
        public int CheckOutDurationDays { get; set; }

        public string Borrower { get; set; }

        public DateTime BorrowDate { get; set; }

        public void CheckIn();

        public void CheckOut(string borrower);

        DateTime GetDueDate();
    }
}
