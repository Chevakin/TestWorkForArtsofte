using System.ComponentModel.DataAnnotations;

namespace TestWorkForArtsofte.Domain.Data.ViewModels
{
    public class ProgrammingLanguageSimpleViewModel
    {
        [Required(ErrorMessage = "Название обязательно")]
        public string Title { get; set; }
    }
}
