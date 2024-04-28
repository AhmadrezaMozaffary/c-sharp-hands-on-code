using FithCourseProject.Data.Context;
using SecondCourseProject.Models;

namespace FithCourseProject.Services
{
    public class FriendsRepositoryService : IFriendsRepositoryService
    {
        FifthDbContext _dbContext;

        public FriendsRepositoryService(FifthDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<FriendModel> Read()
        {
            return _dbContext.Friends.ToList();
        }

        public void Create(FriendModel model)
        {
            _dbContext.Friends.Add(model);
            Save();
        }

        public void Update(FriendModel model)
        {
            _dbContext.Friends.Update(model);
            Save();
        }

        public void Delete(int id)
        {
            var friend = _dbContext.Friends.FirstOrDefault(x => x.Id == id);
            _dbContext.Friends.Remove(friend);

            Save();
        }

        public int GetTotalFriendsCount()
        {
            return _dbContext.Friends.Count();
        }

        private void Save()
        {
            _dbContext.SaveChanges();
        }

    }
}
