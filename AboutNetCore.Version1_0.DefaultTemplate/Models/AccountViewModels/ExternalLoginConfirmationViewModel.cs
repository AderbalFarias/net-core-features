using System.ComponentModel.DataAnnotations;

namespace AboutNetCore.Version1_0.DefaultTemplate.Models.AccountViewModels
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
