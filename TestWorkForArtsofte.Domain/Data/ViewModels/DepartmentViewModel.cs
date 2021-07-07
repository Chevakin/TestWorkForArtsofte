﻿using System;
using System.ComponentModel.DataAnnotations;

namespace TestWorkForArtsofte.Domain.Data.ViewModels
{
    public class DepartmentViewModel
    {
        public int ID { get; set; }

        [Required]
        public string Title { get; set; }

        [Range(1, 10)]
        [Required]
        public int Floor { get; set; }
    }
}
