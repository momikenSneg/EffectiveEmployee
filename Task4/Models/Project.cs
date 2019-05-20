using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task4.Models{
    public class Project{
        public int Id { get; set; }
        public string Name { get; set; }
        public int Premium { get; set; }
        public int? EmployeeId { get; set; }
    }
}
