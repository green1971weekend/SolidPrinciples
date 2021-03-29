using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.SOLID.InterfaceSegregationPrinciple
{
    public interface ILibraryItem
    {
        public string LibraryId { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public int Pages { get; set; }

        public int CheckOutDurationDays { get; set; }

        public string Borrower { get; set; }

        public DateTime BorrowDate { get; set; }

        public void CheckIn();

        public void CheckOut(string borrower);

        DateTime GetDueDate();
    }
}
