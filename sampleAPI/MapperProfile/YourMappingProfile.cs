using AutoMapper;
using sampleAPI.Entity;
using sampleAPI.VeiwModel;

namespace sampleAPI.MapperProfile
{
    public class YourMappingProfile : Profile
    {

        public YourMappingProfile()
        {
            //CreateMap<enity, Dto>();
            CreateMap<Product, ProductRequest>().ReverseMap();
            CreateMap<Order, OrderRequest>().ReverseMap();

            CreateMap<Blog,BlogPostReqeust>().ReverseMap();
            CreateMap<Post, PostRequest>().ReverseMap();
            CreateMap<Post,PostResponse>().ReverseMap();
        }
    }
}
