using CS321_W4D2_ExerciseLogAPI.Core.Modder;
using System;
using System.Collections.Generic;
using System.Text;

namespace CS321_W4D2_ExerciseLogAPI.Core.Services
{
    class ActivityTypeService : IActivityTypeService
    {
        private readonly IActivityTypeRepository _activityTypeRepo;

        public ActivityTypeService(IActivityTypeRepository activityTypeRepo)
        {
            _activityTypeRepo = activityTypeRepo;
        }

        public ActivityType Add(ActivityType activityType)
        {
            _activityTypeRepo.Add(activityType);
            return activityType;
        }

        public ActivityType Get(int id)
        {
            return _activityTypeRepo.Get(id);
        }

        public IEnumerable<ActivityType> GetAll()
        {
            return _activityTypeRepo.GetAll();
        }

        public ActivityType Update(ActivityType updatedActivityType)
        {
            var activityType = _activityTypeRepo.Update(updatedActivityType);
            return activityType;
        }

        public void Remove(ActivityType activityType)
        {
            _activityTypeRepo.Remove(activityType);
        }
    }
}
