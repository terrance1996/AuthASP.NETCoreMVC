using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace AuthTest.Models.AccountViewModels
{
    public class ResendEmailConfirmationModel
    {
        //[BindProperty]
        //public InputModel Input { get; set; }

        //public class InputModel
        //{
        //    /// <summary>
        //    ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        //    ///     directly from your code. This API may change or be removed in future releases.
        //    /// </summary>
        //    [Required]
        //    [EmailAddress]
        //    public string Email { get; set; }
        //}
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
