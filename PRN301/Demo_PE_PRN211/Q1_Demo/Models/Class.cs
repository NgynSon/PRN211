﻿using System;
using System.Collections.Generic;

namespace Q1_Demo.Models
{
    public partial class Class
    {
        public Class()
        {
            Students = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public byte Grade { get; set; }
        public int Schoolyear { get; set; }
        public string Room { get; set; } = null!;

        public virtual SchoolYear SchoolyearNavigation { get; set; } = null!;

        public virtual ICollection<Student> Students { get; set; }
    }
}
