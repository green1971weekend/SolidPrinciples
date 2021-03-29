using Patterns.SOLID.InterfaceSegregationPrinciple.ISPInterfaces;
using System;
using System.Collections.Generic;

namespace Patterns.SOLID.InterfaceSegregationPrinciple
{
    public class DVD : IBorrowableDVD
    {
        public string LibraryId { get; set; }

        public string Title { get; set; }

        public int CheckOutDurationDays { get; set; } = 14;

        public string Borrower { get; set; }

        public DateTime BorrowDate { get; set; }

        public List<string> Actors { get; set; }

        public int RuntimeInMinutes { get; set; }


        public void CheckIn()
        {
            Borrower = "";
        }

        public void CheckOut(string borrower)
        {
            Borrower = borrower;
            BorrowDate = DateTime.Now;
        }

        public DateTime GetDueDate()
        {
            return BorrowDate.AddDays(CheckOutDurationDays);
        }
    }
}
