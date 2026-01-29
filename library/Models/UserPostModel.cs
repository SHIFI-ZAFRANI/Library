using System.ComponentModel.DataAnnotations;

namespace library.Models
{
    public class UserPostModel
    {
        public String name { get; set; }
        [Key]
        public int password { get; set; }

        public String email { get; set; }
        public String phone { get; set; }
    }
}
