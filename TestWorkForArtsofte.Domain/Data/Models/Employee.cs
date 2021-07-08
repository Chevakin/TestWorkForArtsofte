using System;
using TestWorkForArtsofte.Domain.Data.Models;

namespace TestWorkForArtsofte.Domain.Models
{
    public class Employee
    {
        public Employee(string name, string surname, int age, Genders gender, Department department, ProgrammingLanguage programmingLanguage)
            : this()
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new System.ArgumentException($"\"{nameof(name)}\" не может быть неопределенным или пустым.", nameof(name));
            }

            if (string.IsNullOrEmpty(surname))
            {
                throw new System.ArgumentException($"\"{nameof(surname)}\" не может быть неопределенным или пустым.", nameof(surname));
            }

            if (department is null)
            {
                throw new ArgumentNullException(nameof(department));
            }

            if (programmingLanguage is null)
            {
                throw new ArgumentNullException(nameof(programmingLanguage));
            }

            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
            Department = department;
            ProgrammingLanguage = programmingLanguage;
        }

        private Employee()
        {
        }

        public int ID { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        public Genders Gender { get; set; }

        public virtual Department Department { get; set; }

        public virtual ProgrammingLanguage ProgrammingLanguage { get; set; }
    }
}
