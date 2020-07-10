using CS321_W4D2_ExerciseLogAPI.Core.Modder;
using System.Collections.Generic;

namespace CS321_W4D2_ExerciseLogAPI.Core.Services
{
    interface IActivityService
    {
        Activity Add(Activity activity);
        Activity Get(int id);
        IEnumerable<Activity> GetAll();
        void Remove(Activity activity);
        Activity Update(Activity updatedActivity);
    }
}