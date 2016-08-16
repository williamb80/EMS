using System;
using System.ComponentModel.DataAnnotations;
using EMS.Resource.Model;

namespace EMS.Mvc.ViewModels.Model
{
    public class ChurchVM
    {
        [Key]
        public bool Detail { get; set; }

        [Key]
        public long Id { get; set; }

        [Required(ErrorMessageResourceName = "TheNameIsRequired", ErrorMessageResourceType = typeof(ChurchResource))]
        [Display(Name = "Name", ResourceType = typeof(ChurchResource))]
        public string Name { get; set; }

        [Required(ErrorMessageResourceName = "PhoneNumberIsRequired", ErrorMessageResourceType = typeof(ChurchResource))]
        [Display(Name = "Phone", ResourceType = typeof(ChurchResource))]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessageResourceName = "BirthDateIsRequired", ErrorMessageResourceType = typeof(ChurchResource))]
        [Display(Name = "Initials", ResourceType = typeof(ChurchResource))]
        public string Initials { get; set; }

        [Required(ErrorMessageResourceName = "TheNameIsRequired", ErrorMessageResourceType = typeof(ChurchResource))]
        [Display(Name = "BirthDate", ResourceType = typeof(ChurchResource))]
        public DateTime BirthDate { get; set; }
    }
}