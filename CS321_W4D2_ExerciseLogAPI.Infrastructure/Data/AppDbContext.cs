using CS321_W4D2_ExerciseLogAPI.Core.Modder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Text;

namespace CS321_W4D2_ExerciseLogAPI.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Activity> Activities { get; set; }

        public DbSet<ActivityType> ActivityTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
                modelBuilder.Entity<ActivityType>().HasData(
                    new ActivityType { Id = 1, Name = "Running", RecordType = RecordType.DurationAndDistance },
                    new ActivityType { Id = 2, Name = "Weights", RecordType = RecordType.DurationOnly },
                    new ActivityType { Id = 3, Name = "Walking", RecordType = RecordType.DurationAndDistance }
                    );

                modelBuilder.Entity<User>().HasData(
                    new UserStringHandle { Id = 1, Name = "Testing" }
                    );

                modelBuilder.Entity<Activity>().HasData(
                    new Activity { Id = 1, UserId = 1, Date = new DateTime(2019, 6, 19), Distance = 3, Duration = 30, Notes = "Hot!!!" }
                    );

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                base.OnConfiguring(optionsBuilder);
            
                optionsBuilder.UseSqlite("Data Source = ExerciseLog.db")
            }
        }
    }
}
