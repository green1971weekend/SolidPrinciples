using Patterns.Core.Interfaces;
using Patterns.SOLID.InterfaceSegregationPrinciple.ISPInterfaces;
using System;

namespace Patterns.SOLID.InterfaceSegregationPrinciple
{
    /// <summary>
    /// ISP states that the client shold not be forced to depend on interfaces they don't use.
    /// </summary>
    public class InterfaceSegregationPrinciple : IExample
    {
        public void Start()
        {
            //The reason we create such combined interface like IBorrowableDVD is to get access to all necessary properties from here.
            IBorrowableDVD dvd = new DVD();

            Console.ReadLine();
        }
    }
}
