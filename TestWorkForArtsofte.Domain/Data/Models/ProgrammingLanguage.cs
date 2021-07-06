using System.Collections.Generic;

namespace TestWorkForArtsofte.Domain.Models
{
    public class ProgrammingLanguage
    {
        public ProgrammingLanguage(string title)
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new System.ArgumentException($"\"{nameof(title)}\" не может быть неопределенным или пустым.", nameof(title));
            }

            Title = title;
        }

        private ProgrammingLanguage()
        {
            Employees = new HashSet<Employee>();
        }

        //Конечно, Title может быть ключом, но я думаю, что это будет замедлять поиск.
        public int ID { get; set; }

        public string Title { get; set; }

        public virtual HashSet<Employee> Employees { get; set; }
    }
}