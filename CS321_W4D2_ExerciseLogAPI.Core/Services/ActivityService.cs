using CS321_W4D2_ExerciseLogAPI.Core.Modder;
using System;
using System.Collections.Generic;
using System.Text;

namespace CS321_W4D2_ExerciseLogAPI.Core.Services
{
    class ActivityService : IActivityService
    {
        private readonly IActivityRepository _activityRepo;

        public ActivityService(IActivityRepository activityRepo)
        {
            _activityRepo = activityRepo;
        }

        public Activity Add(Activity activity)
        {
            _activityRepo.Add(activity);
            return activity;
        }

        public Activity Get(int id)
        {
            return _activityRepo.Get(id);
        }

        public IEnumerable<Activity> GetAll()
        {
            return _activityRepo.GetAll();
        }

        public Activity Update(Activity updatedActivity)
        {
            var activity = _activityRepo.Update(updatedActivity);
            return activity;
        }

        public void Remove(Activity activity)
        {
            _activityRepo.Remove(activity);
        }
    }
}
