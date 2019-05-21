using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task4.Models{
    public class Employee{
        public int EmployeeId { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public ICollection<Project> Projects { get; set; }
    }
}
