using System.ComponentModel.DataAnnotations;

namespace SixthCourseProject.Models
{
    public class FriendModel
    {
        [Required]
        [DataType(DataType.Text)]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name="Full name", Prompt = "Enter your friend's name")]
        public string Name { get; set; }
        [Required]
        [DataType (DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [Required]
        [DataType(DataType.ImageUrl)]
        public string Avatar { get; set; }
    }
}
