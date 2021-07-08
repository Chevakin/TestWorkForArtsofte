using System.ComponentModel.DataAnnotations;

namespace TestWorkForArtsofte.Domain.Data.Models
{
    public enum Genders
    {
        [Display(Name = "Муж.")]
        Male,

        [Display(Name = "Жен.")]
        Female
    }
}
