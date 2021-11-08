using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeApplication.DAL.Entities
{
    public class Employee : Base.BaseEntity<int>
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Position { get; set; }
        public string LeaderName { get; set; }
    }
}
