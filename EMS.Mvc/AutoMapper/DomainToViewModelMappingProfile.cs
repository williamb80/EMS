using AutoMapper;
using EMS.Domain.Entity;
using EMS.Mvc.ViewModels.Model;

namespace EMS.Mvc.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        protected override void Configure()
        {
            //Mapper.CreateMap<UserVM, User>();
            Mapper.CreateMap<ChurchVM, Church>();
        }
    }
}