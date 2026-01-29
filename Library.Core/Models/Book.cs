using System.Numerics;

namespace library.Core.Models
{
    public class Book
    {
        public String nameBook { get; set; }
        public int Id { get; set; }
   
        public List<Category> Category { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
