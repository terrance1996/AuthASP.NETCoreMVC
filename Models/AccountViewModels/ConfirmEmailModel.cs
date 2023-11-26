using Microsoft.AspNetCore.Mvc;

namespace AuthTest.Models.AccountViewModels
{
    public class ConfirmEmailModel
    {
        [TempData]
        public string StatusMessage { get; set; }
    }
}
