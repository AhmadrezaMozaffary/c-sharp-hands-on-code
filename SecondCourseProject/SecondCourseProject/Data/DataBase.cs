using SecondCourseProject.Models;

namespace SecondCourseProject.Data
{
    public static class DataBase
    {
        private static List<FriendModel> _Friends = new();

        public static void AddFriend(FriendModel friend)
        {
            _Friends.Add(friend);
        }

        public static List<FriendModel> GetFriendsList()
        {
            return _Friends;
        }
    }
}
