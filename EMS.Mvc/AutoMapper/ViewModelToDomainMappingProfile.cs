using AutoMapper;
using EMS.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EMS.Mvc.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        protected override void Configure()
        {
            //Mapper.CreateMap<User, UserViewModel>();
            //Mapper.CreateMap<Church, ChurchViewModel>();
        }
    }
}