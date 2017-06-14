using System;
using System.ComponentModel.DataAnnotations;
using EMS.Resource.Registration;
using System.Collections.Generic;
using EMS.Framework.Resource;

namespace EMS.Mvc.ViewModels.Registration
{
    public class ChurchViewModel
    {
        [Key]
        public long Id { get; set; }

        [MaxLength(length: 150, ErrorMessageResourceName = "YouHaveReachedTheSizeMaximumCharacters150", ErrorMessageResourceType = typeof(ValidationResource))]
        [Required(ErrorMessageResourceName = "TheNameIsRequired", ErrorMessageResourceType = typeof(ChurchResource))]
        [Display(Name = "Name", ResourceType = typeof(ChurchResource))]
        public string Name { get; set; }

        [Required(ErrorMessageResourceName = "PhoneNumberIsRequired", ErrorMessageResourceType = typeof(ChurchResource))]
        [Display(Name = "Phone", ResourceType = typeof(ChurchResource))]        
        [Phone]
        public string FirstPhoneNumber { get; set; }

        [Display(Name = "Phone", ResourceType = typeof(ChurchResource))]
        [Phone]
        public string SecondPhoneNumber { get; set; }


        public string CNPJ { get; set; }

        [MaxLength(length: 10, ErrorMessageResourceName = "YouHaveReachedTheSizeMaximumCharacters10", ErrorMessageResourceType = typeof(ChurchResource))]
        [Required(ErrorMessageResourceName = "InitialsIsRequired", ErrorMessageResourceType = typeof(ChurchResource))]
        [Display(Name = "Initials", ResourceType = typeof(ChurchResource))]
        public string Initials { get; set; }

        [Display(Name = "BirthDate", ResourceType = typeof(ChurchResource))]
        public DateTime BirthDate { get; set; }

        public AddressViewModel Addresses { get; set; }
        public string Email { get; set; }
        public virtual IEnumerable<BranchViewModel> Branches { get; set; }
        public virtual IEnumerable<RepresentativeViewModel> Representatives { get; set; }
    }
}