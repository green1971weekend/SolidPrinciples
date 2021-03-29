namespace Patterns.SOLID.LiskovSubstitutionPrinciple
{
    public abstract class BaseEmployee : IEmployee
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public decimal Salary { get; set; }

        /// <summary>
        /// There is some important things like covariance and contravariance, preconditions and postconditions.
        /// Covariance states that we cannot change return type in overrided methods.
        /// Contravariance states that we cannot change the input arguments type.
        /// Preconditions says that we cannot strengthen input checking in inherited methods.
        /// Postconditions says that we cannot weaken (for example return value should be returned only in a certain range) condition in the child items. 
        /// </summary>
        /// <param name="rank"></param>
        public virtual void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 12.50M;

            Salary = baseAmount + (rank * 2);
        }
    }
}
