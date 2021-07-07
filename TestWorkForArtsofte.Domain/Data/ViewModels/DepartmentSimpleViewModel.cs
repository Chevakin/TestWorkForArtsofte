using System;
using System.ComponentModel.DataAnnotations;

namespace TestWorkForArtsofte.Domain.Data.ViewModels
{
    public class DepartmentSimpleViewModel
    {
        [Required(ErrorMessage = "Название обязательно.")]
        public string Title { get; set; }

        [Range(1, Consts.CountFloor, ErrorMessage = "Номер этажа должен быть от 1 до 10.")]
        [Required(ErrorMessage = "Этаж обязателен.")]
        public int Floor { get; set; }
    }
}
