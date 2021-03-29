using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.SOLID.InterfaceSegregationPrinciple.ISPInterfaces
{
    public interface IDVD : ILibraryItem
    {
        public List<string> Actors { get; set; }

        public int RuntimeInMinutes { get; set; }
    }
}
