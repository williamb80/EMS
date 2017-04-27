using EMS.Domain.Entity;
using EMS.Resource.Registration;
using System;
using System.ComponentModel.DataAnnotations;

namespace EMS.Mvc.ViewModels.Registration
{
    public class RepresentativeViewModel
    {

        [Key]
        public long Id { get; set; }

        [Required(ErrorMessageResourceName = "NameIsRequired", ErrorMessageResourceType = typeof(RepresentativeResource))]
        [Display(Name = "Church", ResourceType = typeof(RepresentativeResource))]
        public string Name { get; set; }

        [Display(Name = "BirthDate", ResourceType = typeof(RepresentativeResource))]
        public DateTime BirthDate { get; set; }

        [Display(Name = "FirstPhoneNumber", ResourceType = typeof(RepresentativeResource))]
        public string FirstPhoneNumber { get; set; }

        [Display(Name = "SecondPhoneNumber", ResourceType = typeof(RepresentativeResource))]
        public string SecondPhoneNumber { get; set; }

        [Display(Name = "Email", ResourceType = typeof(RepresentativeResource))]
        public string Email { get; set; }

        //[Required(ErrorMessageResourceName = "PhoneNumberIsRequired", ErrorMessageResourceType = typeof(AddressResource))]
        [Display(Name = "Address", ResourceType = typeof(RepresentativeResource))]
        public AddressViewModel AddressViewModel { get; set; }

        [Display(Name = "Church", ResourceType = typeof(ChurchResource))]
        public ChurchViewModel ChurchViewModel { get; set; }
    }
}