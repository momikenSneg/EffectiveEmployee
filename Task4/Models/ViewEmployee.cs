using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task4.Models
{
    public class ViewEmployee : Employee
    {

        public ViewEmployee(Employee e)
        {
            this.FullName = e.FullName;
            this.EmployeeId = e.EmployeeId;
            this.Projects = e.Projects;
            this.Age = e.Age;
        }

        public int PremiumSum { get; set; }
    }
}
