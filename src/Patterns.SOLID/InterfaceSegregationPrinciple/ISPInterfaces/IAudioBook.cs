using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.SOLID.InterfaceSegregationPrinciple.ISPInterfaces
{
    public interface IAudioBook : ILibraryItem
    {
        public int RuntimeInMinutes { get; set; }
    }
}
