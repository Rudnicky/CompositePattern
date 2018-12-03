using System;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new TeamMember("Paul", 8000);
            Employee employee2 = new TeamMember("Jack", 30000);
            Employee teamLeader = new TeamLeader("Marg", 750000);

            teamLeader.Add(employee1);
            teamLeader.Add(employee2);

            Console.WriteLine(teamLeader.GetData());
            Console.Read();
        }
    }
}
