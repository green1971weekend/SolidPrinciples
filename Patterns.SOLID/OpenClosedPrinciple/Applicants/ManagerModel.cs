using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.SOLID.OpenClosedPrinciple
{
    public class ManagerModel : IApplicantModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IAccounts AccountProcessor { get; set; } = new ManagerAccounts();
    }
}
