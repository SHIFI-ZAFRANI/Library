using AutoMapper;
using library.Core.Models;
using library.Models;

namespace library
{
    public class MappingPostModel:Profile
    {
        public MappingPostModel() {
            CreateMap<BookPostModel, Book>();
            CreateMap<UserPostModel, User>();
            CreateMap<CategoryPostModel, Category>();
        }
    }
}
