using AutoMapper;
using EMS.Domain.Entity;
using EMS.Mvc.ViewModels.Registration;
using System.Collections.Generic;

namespace EMS.Mvc.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        protected override void Configure()
        {
            //Mapper.CreateMap<UserVM, User>();
            Mapper.CreateMap<Church, ChurchViewModel>();
            Mapper.CreateMap<Address, AddressViewModel>();
            Mapper.CreateMap<Branch, BranchViewModel>();
            Mapper.CreateMap<Representative, RepresentativeViewModel>();
            Mapper.CreateMap<IEnumerable<Representative>, IEnumerable<RepresentativeViewModel>>();
        }
    }
}