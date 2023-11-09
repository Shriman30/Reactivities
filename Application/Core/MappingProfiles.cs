
using AutoMapper;
using Domain;

namespace Application.Core
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            // map entity from entity framework to request 
            CreateMap<Activity,Activity>();
        }
    }
}