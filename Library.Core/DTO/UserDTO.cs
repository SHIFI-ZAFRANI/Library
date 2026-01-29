using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.DTO
{
    public class UserDTO
    {
        public String name { get; set; }
        [Key]
        public int password { get; set; }

        public String email { get; set; }
        public String phone { get; set; }
    }
}
