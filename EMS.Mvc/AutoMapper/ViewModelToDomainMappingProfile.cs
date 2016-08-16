using AutoMapper;
using EMS.Domain.Entity;
using EMS.Mvc.ViewModels.Model;

namespace EMS.Mvc.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        protected override void Configure()
        {
            //Mapper.CreateMap<User, UserViewModel>();
           Mapper.CreateMap<Church, ChurchVM>();
        }
    }
}