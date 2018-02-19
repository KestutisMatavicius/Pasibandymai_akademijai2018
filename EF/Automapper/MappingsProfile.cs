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
            //.ForMember(dest => dest., config => config.Ignore())
            .ForMember(dest => dest.Url, opt => opt.MapFrom(src => src.Url))
            .ForMember(dest => dest.Posts,
                    opt => opt.MapFrom(src => Mapper.Map<ICollection<Post>, List<PostDto>>(src.Post)));

            //.ReverseMap();


            CreateMap<Post, PostDto>()
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
            //.ForMember(dest => dest., config => config.Ignore())
            .ReverseMap();



            /*CreateMap<Tpfootnote, FootnoteViewDto>()
                .ForMember(dest => dest.EndDate, opt => opt.ResolveUsing<ViewEnddateResolver, DateTime?>(src => src.Enddate))
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Pid))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => Mapper.Map<Tpdomainvalue, IdName>(src.StatusNavigation)))
                .ForMember(dest => dest.NationalFlag, opt => opt.MapFrom(src => Mapper.Map<Tpdomainvalue, IdName>(src.NationalflagNavigation)))
                .ForMember(dest => dest.FootnoteTypeId, opt => opt.MapFrom(src => src.FootnotetypeNavigation))
                .ForMember(dest => dest.Descriptions,
                    opt => opt.MapFrom(src => Mapper.Map<ICollection<Tcftntdscrptnprds>, List<FootnoteDescriptionViewDto>>(src.Tcftntdscrptnprds)));

            CreateMap<Tcftntdscrptnprds, FootnoteDescriptionViewDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Pid))
                .ForMember(dest => dest.DescriptionItems,
                    opt => opt.MapFrom(src => Mapper.Map<ICollection<Tcftntdscrptnprdsdscrptns>, List<FootnoteDescriptionItemViewDto>>(src.Tcftntdscrptnprdsdscrptns)));

            CreateMap<Tcftntdscrptnprdsdscrptns, FootnoteDescriptionItemViewDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Pid))
                .ForMember(dest => dest.Language, opt => opt.MapFrom(src => Mapper.Map<Tplanguage, IdName>(src.LanguageNavigation)))
                .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Text));*/
        }







    }
}
