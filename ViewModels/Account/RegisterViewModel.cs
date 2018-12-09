using System.ComponentModel.DataAnnotations;

namespace Localization.ViewModels.Account
{
    public class RegisterViewModel
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Age")]
        public string Age { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
