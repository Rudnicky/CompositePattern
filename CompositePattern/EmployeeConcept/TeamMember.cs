namespace CompositePattern
{
    public class TeamMember : Employee
    {
        public TeamMember(string name, double salary)
            : base(name, salary)
        {

        }

        public override void Add(Employee employee)
        {
            // operation not permitted since this is a leaf node
        }

        public override void Remove(Employee employee)
        {
            // operation not permitted since this is a leaf node
        }

        public override string GetData()
        {
            return "Name: " + Name + "\tSalary: " + Salary.ToString("N2");
        }
    }
}
