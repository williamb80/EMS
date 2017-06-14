using AutoMapper;
using EMS.Domain.Entity;
using EMS.Mvc.ViewModels.Registration;
using System.Collections.Generic;

namespace EMS.Mvc.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        protected override void Configure()
        {
            //Mapper.CreateMap<User, UserViewModel>();
            Mapper.CreateMap<ChurchViewModel, Church>();
            Mapper.CreateMap<AddressViewModel, Address>();
            Mapper.CreateMap<BranchViewModel, Branch>();
            Mapper.CreateMap<RepresentativeViewModel, Representative>();
            Mapper.CreateMap<IEnumerable<Representative>, IEnumerable<RepresentativeViewModel>>();
        }
    }
}