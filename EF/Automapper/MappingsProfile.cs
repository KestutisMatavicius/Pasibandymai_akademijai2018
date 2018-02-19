using AutoMapper;
using EF.Automapper.Dto;
using EF.models;
using System.Collections.Generic;

namespace EF.Automapper
{
    public class MappingsProfile : Profile
    {
        public MappingsProfile()
        {
            CreateMap<Blog, BlogDto>()
            .ForMember(dest => dest.Posts,
                    opt => opt.MapFrom(src => Mapper.Map<ICollection<Post>, List<PostDto>>(src.Post)));

            CreateMap<Post, PostDto>();
        }
    }
}
