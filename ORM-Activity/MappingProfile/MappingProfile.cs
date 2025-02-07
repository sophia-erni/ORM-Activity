using AutoMapper;
using ORM_Activity.DTOs;
using ORM_Activity.Models;

namespace ORM_Activity.MappingProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<CreateAuthor, Author>();
            CreateMap<GetAuthor, Author>();
            CreateMap<Author, GetAuthorDto>()
                .ForMember(dest => dest.Books, opt => opt.MapFrom(src => src.Books))
                .ForMember(dest => dest.AuthorsPublishers, opt => opt.MapFrom(src => src.AuthorsPublishers));

            CreateMap<CreateBook, Book>();
            CreateMap<Book, GetBookDto>();
            
            CreateMap<AuthorPublisher, GetAuthorPublisherDto>();

            CreateMap<CreatePublisher, Publisher>();
            CreateMap<Publisher, GetPublisherDto>();


            CreateMap<CreateUser,User>(); 
            CreateMap<User,GetUserDto>();

            CreateMap<CreateUserProfile,UserProfile>();
            CreateMap<UserProfile, GetUserProfileDto>()
                .ForMember(dest => dest.Books, opt => opt.MapFrom(src => src.Books));

        }
    }
}
