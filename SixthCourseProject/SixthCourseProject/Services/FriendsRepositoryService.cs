using SixthCourseProject.Data.Context;
using SixthCourseProject.Models;

namespace SixthCourseProject.Services
{
    public class FriendsRepositoryService : IFriendsRepositoryService
    {
        SixthDbContext _dbContext;

        public FriendsRepositoryService(SixthDbContext dbContext)
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
