using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAPI_II.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Department { get; set; }
        public string DateJoined { get; set; }
        public string PhotoFileName { get; set; }
    }
}
