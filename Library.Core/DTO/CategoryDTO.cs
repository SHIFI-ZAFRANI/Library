using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.DTO
{
    public class CategoryDTO
    {
        [Key]
        public int idCategory { get; set; }
        public String nameCategory { get; set; }
    }
}
