using AutoMapper;
using library.Core.Models;
using Library.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core
{
    public class MappingProfile:Profile
    {
         public MappingProfile()
        {
            CreateMap<Book,BookDTO>().ReverseMap();
            CreateMap<User,UserDTO>().ReverseMap();
            CreateMap<Category,CategoryDTO>().ReverseMap();
        }
    }
}
