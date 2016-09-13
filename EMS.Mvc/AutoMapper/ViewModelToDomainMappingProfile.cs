﻿using AutoMapper;
using EMS.Domain.Entity;
using EMS.Mvc.ViewModels.Registration;

namespace EMS.Mvc.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        protected override void Configure()
        {
            //Mapper.CreateMap<User, UserViewModel>();
            Mapper.CreateMap<Church, ChurchViewModel>();
            Mapper.CreateMap<Address, AddressViewModel>();
            Mapper.CreateMap<Branch, BranchViewModel>();
            Mapper.CreateMap<Representative, RepresentativeViewModel>();
        }
    }
}