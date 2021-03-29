using System;

namespace Patterns.SOLID.InterfaceSegregationPrinciple
{
    public class Book : ILibraryItem
    {
        public string LibraryId { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public int Pages { get; set; }

        public int CheckOutDurationDays { get; set; }

        public string Borrower { get; set; }

        public DateTime BorrowDate { get; set; }


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
