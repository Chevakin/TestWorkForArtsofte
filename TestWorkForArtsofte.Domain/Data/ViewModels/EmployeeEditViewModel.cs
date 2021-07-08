using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using TestWorkForArtsofte.Domain.Data.Models;

namespace TestWorkForArtsofte.Domain.Data.ViewModels
{
    public class EmployeeEditViewModel
    {
        [Range(0, int.MaxValue)]
        [Required]
        public int ID { get; set; }

        [DisplayName("Имя")]
        [Required(ErrorMessage = "Имя обязательно.")]
        public string Name { get; set; }

        [DisplayName("Фамилия")]
        [Required(ErrorMessage = "Фамилия обязательна.")]
        public string Surname { get; set; }

        [DisplayName("Возраст")]
        [Range(14, 150)]
        [Required(ErrorMessage = "Возраст обязателен")]
        public int Age { get; set; }

        [DisplayName("Пол")]
        [Required(ErrorMessage = "Пол обязателен")]
        public Genders Gender { get; set; }

        [DisplayName("Отдел")]
        [Required(ErrorMessage = "Отдел обязателен")]
        public int Department { get; set; }

        [DisplayName("Язык программирования")]
        [Required(ErrorMessage = "Язык программирования обязателен")]
        public int ProgrammingLanguage { get; set; }
    }
}
