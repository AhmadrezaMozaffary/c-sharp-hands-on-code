namespace FirstCourseProject.Models
{
    public class FriendModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Avatar { get; set; }

        public FriendModel(int id, string name, string phoneNumber, string avatar)
        {
            Id = id;
            Name = name;
            PhoneNumber = phoneNumber;
            Avatar = avatar;
        }
    }
}
