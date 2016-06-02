using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EMS.Mvc.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        protected override void Configure()
        {
            //Mapper.CreateMap<UserViewModel, User>();
            //Mapper.CreateMap<ChurchViewModel, Church>();
        }
    }
}