using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.SOLID.InterfaceSegregationPrinciple
{
    public interface ILibraryItem
    {
        public string LibraryId { get; set; }

        public string Title { get; set; }
    }
}
