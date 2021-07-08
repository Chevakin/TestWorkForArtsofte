using System.ComponentModel.DataAnnotations;

namespace TestWorkForArtsofte.Domain.Data.ViewModels
{
    public class SimpleSelectViewModel
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public string Info { get; set; }
    }
}
