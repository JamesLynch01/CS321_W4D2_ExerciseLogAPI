﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace CS321_W4D2_ExerciseLogAPI.ApiModels
{
    public static class ActivityMappingExtenstions
    {

        public static ActivityModel ToApiModel(this Activity activity)
        {
            return new ActivityModel
            {
                Id = activity.Id,
                Date = activity.Date,
                ActivityTypeId = activity.ActivityTypeId,
                ActivityType = activity.ActivityType.Name,
                Duration = activity.Duraction,
                Distance = activity.Distance,
                User = activity.User.Name,
                UserId = activity.UserId,
                Notes = activity.Notes,
                // TODO: fill in property mappings
                // TODO: the ActivityType property should contain the name of the activity type
                // TODO: the User property should contain the user's name
            };
        }

        public static Activity ToDomainModel(this ActivityModel activityModel)
        {
            return new Activity
            {
                Id = activityModel.Id,
                Date = activityModel.Date,
                Duration = activityModel.Duration,
                Distance = activityModel.Distance,
                Notes = activityModel.Notes,
                UserId = activityModel.UserId,
                ActivityTypeId = activityModel.ActivityTypeId,

                // TODO: fill in property mappings
                // TODO: leave User and ActivityType null
            };
        }

        public static IEnumerable<ActivityModel> ToApiModels(this IEnumerable<Activity> activities)
        {
            return activities.Select(a => a.ToApiModel());
        }

        public static IEnumerable<Activity> ToDomainModels(this IEnumerable<ActivityModel> activityModels)
        {
            return activityModels.Select(a => a.ToDomainModel());
        }
    }
}
