﻿using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace CS321_W4D2_ExerciseLogAPI.Core.Modder
{
    public class Activity
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int ActivityTypeId { get; set; }
        public ActivityType ActivityType { get; set; }
        public double Duration { get; set; }
        public double Distance { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string Notes { get; set; }
    }
}
