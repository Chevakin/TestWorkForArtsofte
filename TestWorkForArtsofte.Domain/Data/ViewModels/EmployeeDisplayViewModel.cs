using System.ComponentModel;

namespace TestWorkForArtsofte.Domain.Data.ViewModels
{
    public class EmployeeDisplayViewModel
    {
        public int ID { get; set; }

        [DisplayName("Имя")]
        public string Name { get; set; }

        [DisplayName("Фамилия")]
        public string Surname { get; set; }

        [DisplayName("Возраст")]
        public int Age { get; set; }

        [DisplayName("Пол")]
        public string Gender { get; set; }

        [DisplayName("Отдел")]
        public string Department { get; set; }

        [DisplayName("Язык программирования")]
        public string ProgrammingLanguage { get; set; }
    }
}
