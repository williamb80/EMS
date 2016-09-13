using AutoMapper;
using EMS.Domain.Entity;
using EMS.Mvc.ViewModels.Registration;

namespace EMS.Mvc.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        protected override void Configure()
        {
            //Mapper.CreateMap<UserVM, User>();
            Mapper.CreateMap<ChurchViewModel, Church>();
            Mapper.CreateMap<AddressViewModel, Address>();
            Mapper.CreateMap<BranchViewModel, Branch>();
            Mapper.CreateMap<RepresentativeViewModel, Representative>();
        }
    }
}