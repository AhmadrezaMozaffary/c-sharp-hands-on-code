using SixthCourseProject.Models;

namespace SixthCourseProject.Services
{
    public interface IFriendsRepositoryService
    {
        void Create(FriendModel model);
        void Delete(int id);
        List<FriendModel> Read();
        void Update(FriendModel model);
        int GetTotalFriendsCount();
    }
}