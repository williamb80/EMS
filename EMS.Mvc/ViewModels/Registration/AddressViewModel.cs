using EMS.Resource.Registration;
using System.ComponentModel.DataAnnotations;

namespace EMS.Mvc.ViewModels.Registration
{
    public class AddressViewModel
    {
        [Key]
        public long Id { get; set; }

        //[Required(ErrorMessageResourceName = "PhoneNumberIsRequired", ErrorMessageResourceType = typeof(AddressResource))]
        [Display(Name = "Street", ResourceType = typeof(AddressResource))]
        public string Street { get; set; }

        //[Required(ErrorMessageResourceName = "PhoneNumberIsRequired", ErrorMessageResourceType = typeof(AddressResource))]
        [Display(Name = "Number", ResourceType = typeof(AddressResource))]
        public string Number { get; set; }

        //[Required(ErrorMessageResourceName = "PhoneNumberIsRequired", ErrorMessageResourceType = typeof(AddressResource))]
        [Display(Name = "City", ResourceType = typeof(AddressResource))]
        public string City { get; set; }

        //[Required(ErrorMessageResourceName = "PhoneNumberIsRequired", ErrorMessageResourceType = typeof(AddressResource))]
        [Display(Name = "State", ResourceType = typeof(AddressResource))]
        public string State { get; set; }
        
        //[Required(ErrorMessageResourceName = "PhoneNumberIsRequired", ErrorMessageResourceType = typeof(AddressResource))]
        [Display(Name = "ZipCode", ResourceType = typeof(AddressResource))]
        public string ZipCode { get; set; }

    }
}