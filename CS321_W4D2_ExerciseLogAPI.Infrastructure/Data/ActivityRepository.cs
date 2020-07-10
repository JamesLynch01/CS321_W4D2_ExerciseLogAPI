using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using CS321_W4D2_ExerciseLogAPI.Core.Modder;
using CS321_W4D2_ExerciseLogAPI.Core.Services;
using System.Xml.Linq;

namespace CS321_W4D2_ExerciseLogAPI.Infrastructure.Data
{
    public class ActivityRepository : IActivityRepository
    {
        private readonly AppDbContext _dbContext;
        public ActivityRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Activity Add(Activity item)
        {
            _dbContext.Add(item);
            return item;
        }

        public ActivityType Get(int id)
        {
            return _dbContext.Activities
                .SingleOrDefault(a => a.Id == id);
        }

        public IEnumerable<Activity> GetAll()
        {
            return _dbContext.Activities;
        }

        public Activity Update(Activity updatedActivity)
        {
            var currentActivity = _dbContext.Activities.Find(updatedActivity.Id);
            if (currentActivity == null) return null;

            _dbContext.ActivityTypes.Update(currentActivity);
            _dbContext.SaveChanges();
            return currentActivity;
        }

        public void Remove(Activity activity)
        {
            _dbContext.Activities.Remove(activity);
            _dbContext.SaveChanges();
        }
    }
}
