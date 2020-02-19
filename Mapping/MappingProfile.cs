using angular_dotnet_core.Controllers.Resources;
using angular_dotnet_core.Models;
using AutoMapper;

namespace angular_dotnet_core.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Make, MakeResource>();
            CreateMap<Model, ModelResource>();
        }
    }
}