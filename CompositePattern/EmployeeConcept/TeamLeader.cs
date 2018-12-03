using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    public class TeamLeader : Employee
    {
        private List<Employee> _listOfEmployees = new List<Employee>();

        public TeamLeader(string name, double salary) 
            : base(name, salary)
        {

        }

        public override void Add(Employee employee)
        {
            _listOfEmployees.Add(employee);
        }

        public override void Remove(Employee employee)
        {
            _listOfEmployees.Remove(employee);
        }

        public override string GetData()
        {
            var stringBuilderEmployee = new StringBuilder();

            foreach (var element in _listOfEmployees)
            {
                stringBuilderEmployee.Append(element.GetData() + "\n");
            }

            return stringBuilderEmployee.ToString();
        }
    }
}
