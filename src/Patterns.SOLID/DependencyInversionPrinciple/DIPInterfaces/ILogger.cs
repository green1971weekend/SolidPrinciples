using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.SOLID.DependencyInversionPrinciple.DIPInterfaces
{
    public interface ILogger
    {
        void Log(string message);
    }
}
