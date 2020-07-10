using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using CS321_W4D2_ExerciseLogAPI.Core.Modder;
using CS321_W4D2_ExerciseLogAPI.Core.Services;

namespace CS321_W4D2_ExerciseLogAPI.Infrastructure.Data
    {
        public class ActivityTypeRepository : IActivityTypeRepository
        {
            private readonly AppDbContext _dbContext;
            public ActivityTypeRepository(AppDbContext dbContext)
            {
                _dbContext = dbContext;
            }

            public ActivityType Add(ActivityType item)
            {
                _dbContext.Add(item);
                return item;
            }

            public ActivityType Get(int id)
            {
                return _dbContext.ActivityTypes
                    .SingleOrDefault(t => t.Id == id);
            }

            public IEnumerable<ActivityType> GetAll()
            {
                return _dbContext.ActivityTypes;
            }

            public ActivityType Update(ActivityType updatedActivityType)
            {
                var currentActivityType = _dbContext.ActivityTypes.Find(updatedActivityType.Id);
                if (currentActivityType == null) return null;

                _dbContext.ActivityTypes.Update(currentActivityType);
                _dbContext.SaveChanges();
                return currentActivityType;
            }

            public void Remove(ActivityType activityType)
            {
                _dbContext.ActivityTypes.Remove(activityType);
                _dbContext.SaveChanges();
            }
        }
    }


