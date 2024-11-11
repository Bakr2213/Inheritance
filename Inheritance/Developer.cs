namespace Inheritance
{
    public class Developer : Employee
    {
        private const decimal Commission = 0.03m;
        public Developer(int id, string name, decimal loggedHours, decimal wage, bool TaskCompleted ) : base(id, name, loggedHours, wage)
        {
            this.TaskCompleted = TaskCompleted;
        }
        protected bool TaskCompleted { get; set; }
        protected override decimal Calculate()
        {
            return base.Calculate() + CalculateBonus();
        }
        private decimal CalculateBonus()
        {
            if (TaskCompleted)
                return base.Calculate() * Commission;

            return 0;
           
        }
        public override string ToString()
        {
            return base.ToString() +
                $"\nTaskCompleted : {(TaskCompleted ? "Yes" : "No")}" +
                $"\nBonus : {Math.Round(CalculateBonus(), 2):N0}" +
                $"\nNet Salary : {Math.Round(this.Calculate(), 2):N0}";

        }

    }
}
