using Patterns.Core.Interfaces;
using Patterns.SOLID.LiskovSubstitutionPrinciple;
using Patterns.SOLID.OpenClosedPrinciple;
using Patterns.SOLID.SingleResponsibilityPrinciple;

namespace Patterns.Common
{
    public class Implementation
    {
        public IExample GetSingleResponsibilityPrincipleInstance()
        {
            return new SingleResponsibilityPrinciple();
        }

        public IExample GetOpenClosedPrincipleInstance()
        {
            return new OpenClosedPrinciple();
        }

        public IExample GetLiskovSubstitutionPrincipleInstance()
        {
            return new LiskovSubstitutionPrinciple();
        }
    }
}
