using EMS.Resource.Registration;
using System;
using System.ComponentModel.DataAnnotations;

namespace EMS.Mvc.ViewModels.Registration
{
    public class BranchViewModel
    {
        [Key]
        public long Id { get; set; }

        //[Required(ErrorMessageResourceName = "PhoneNumberIsRequired", ErrorMessageResourceType = typeof(AddressResource))]
        [Display(Name = "Church", ResourceType = typeof(BranchResource))]
        public ChurchViewModel Church { get; set; }

        //[Required(ErrorMessageResourceName = "PhoneNumberIsRequired", ErrorMessageResourceType = typeof(AddressResource))]
        [Display(Name = "Name", ResourceType = typeof(BranchResource))]
        public string Name { get; set; }

        //[Required(ErrorMessageResourceName = "PhoneNumberIsRequired", ErrorMessageResourceType = typeof(AddressResource))]
        [Display(Name = "Initials", ResourceType = typeof(BranchResource))]
        public string Initials { get; set; }

        //[Required(ErrorMessageResourceName = "PhoneNumberIsRequired", ErrorMessageResourceType = typeof(AddressResource))]
        [Display(Name = "BirthDate", ResourceType = typeof(BranchResource))]
        public DateTime BirthDate { get; set; }

        //[Required(ErrorMessageResourceName = "PhoneNumberIsRequired", ErrorMessageResourceType = typeof(AddressResource))]
        [Display(Name = "Phone", ResourceType = typeof(BranchResource))]
        public string FirstPhoneNumber { get; set; }

        //[Required(ErrorMessageResourceName = "PhoneNumberIsRequired", ErrorMessageResourceType = typeof(AddressResource))]
        [Display(Name = "Phone", ResourceType = typeof(BranchResource))]
        public string SecondPhoneNumber { get; set; }

        //[Required(ErrorMessageResourceName = "PhoneNumberIsRequired", ErrorMessageResourceType = typeof(AddressResource))]
        [Display(Name = "CNPJ", ResourceType = typeof(BranchResource))]
        public string CNPJ { get; set; }

    }
}