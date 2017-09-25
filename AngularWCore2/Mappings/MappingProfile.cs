using AngularWCore2.Models;
using AngularWCore2.Models.Resources;
using AutoMapper;

namespace AngularWCore2.Mappings
{
    public class MappingProfile : Profile
    {

        public MappingProfile()
        {
            CreateMap<Personel, PersonelResource>().ReverseMap();
            CreateMap<PersonelResource, Personel>().ReverseMap();

        }

    }
}
