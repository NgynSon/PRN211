﻿using System;
using System.Collections.Generic;

namespace Q3_Demo4_Empty.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Orders = new HashSet<Order>();
        }

        public int EmployeeId { get; set; }
        public string LastName { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public int? DepartmentId { get; set; }
        public string? Title { get; set; }
        public string? TitleOfCourtesy { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
        public string? Address { get; set; }

        public virtual Department? Department { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
