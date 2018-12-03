namespace CompositePattern
{
    public abstract class Employee
    {
        #region Protected Fields
        protected readonly string Name;
        protected readonly double Salary;
        #endregion

        #region Constructor
        public Employee(string name, double salary)
        {
            this.Name = name;
            this.Salary = salary;
        }
        #endregion

        #region Abstract Methods
        public abstract void Add(Employee employee);

        public abstract void Remove(Employee employee);

        public abstract string GetData();
        #endregion
    }
}
