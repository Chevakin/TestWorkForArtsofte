using TestWorkForArtsofte.Domain.Models;

namespace TestWorkForArtsofte.Domain.Data.DTOs
{
    public class EmployeeDto
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        public Genders Gender { get; set; }

        public DepartmentDto Department { get; set; }

        public ProgrammingLanguageDto ProgrammingLanguage { get; set; }
    }
}
