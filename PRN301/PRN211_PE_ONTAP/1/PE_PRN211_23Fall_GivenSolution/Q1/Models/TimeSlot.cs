using System;
using System.Collections.Generic;

namespace Q1.Models
{
    public partial class TimeSlot
    {
        public TimeSlot()
        {
            Schedules = new HashSet<Schedule>();
        }

        public int Id { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string FormattedTimeRange => $"{StartTime} - {EndTime}";

        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
