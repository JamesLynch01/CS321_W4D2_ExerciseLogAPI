using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using CS321_W4D2_ExerciseLogAPI.Core.Modder;
using CS321_W4D2_ExerciseLogAPI.Core.Services;

namespace CS321_W4D2_ExerciseLogAPI.Infrastructure.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _dbContext;
        public UserRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public User Add(User item)
        {
            _dbContext.Add(item);
            return item;
        }

        public User Get(int id)
        {
            return _dbContext.Users
                .SingleOrDefault(u => u.Id == id);
        }

        public IEnumerable<User> GetAll()
        {
            return _dbContext.Users;
        }

        public User Update(User updatedUser)
        {
            var currentUser = _dbContext.Users.Find(updatedUser.Id);
            if (currentUser == null) return null;

            _dbContext.Users.Update(currentUser);
            _dbContext.SaveChanges();
            return currentUser;
        }

        public void Remove(User user)
        {
            _dbContext.Users.Remove(user);
            _dbContext.SaveChanges();
        }
    }
}
