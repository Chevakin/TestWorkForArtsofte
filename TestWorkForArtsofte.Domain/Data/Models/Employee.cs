namespace TestWorkForArtsofte.Domain.Models
{
    public class Employee
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        public Genders Gender { get; set; }

        public virtual Department Department { get; set; }

        public virtual ProgrammingLanguage ProgrammingLanguage { get; set; }
    }
}
