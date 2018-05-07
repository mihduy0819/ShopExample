using AutoMapper;
using Model.Model;
using WebSite.Models;

namespace WebSite.Mappings
{
    public class AutoMappingConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<Post, PostViewModel>();
                config.CreateMap<PostCategory, PostCategoryViewModel>();
                config.CreateMap<Tag, TagViewModel>();
            });
        }
    }
}