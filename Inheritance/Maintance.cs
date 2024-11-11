namespace Inheritance
{
    public class Maintance : Employee
    {
        private const decimal Hardship = 100m;
        public Maintance(int id, string name, decimal loggedHours, decimal wage) : base(id, name, loggedHours, wage)
        {
            
        }
        protected override decimal Calculate()
        {
            return base.Calculate() + Hardship;
        }
      

        public override string ToString()
        {
            return base.ToString() +
                $"\nHardship : {Math.Round(Hardship, 2):N0}" +
                $"\nNet Salary : {Math.Round(this.Calculate(), 2):N0}";

        }

    }
}
