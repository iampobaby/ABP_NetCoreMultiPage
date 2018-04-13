using System.ComponentModel.DataAnnotations;

namespace NetCoreMultiPage.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}