using System.ComponentModel.DataAnnotations;

namespace library.Models
{
    public class CategoryPostModel
    {
        [Key]
        public int idCategory { get; set; }
        public String nameCategory { get; set; }
    }
}
