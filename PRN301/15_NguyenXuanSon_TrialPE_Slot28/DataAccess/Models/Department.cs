﻿using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Department
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; } = new List<Employee>();

    public virtual ICollection<Project> Projects { get; } = new List<Project>();
}
