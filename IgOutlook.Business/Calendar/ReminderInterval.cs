﻿using System;

namespace IgOutlook.Business.Calendar
{
    public class ReminderInterval
    {
        public TimeSpan? TimeInterval { get; set; }
        public string Description { get; set; }

        public ReminderInterval(TimeSpan? timeInterval, string description)
        {
            TimeInterval = timeInterval;
            Description = description;
        }
    }
}
