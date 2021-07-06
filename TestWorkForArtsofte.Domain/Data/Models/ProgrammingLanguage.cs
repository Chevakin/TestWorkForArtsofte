namespace TestWorkForArtsofte.Domain.Models
{
    public class ProgrammingLanguage
    {
        //Конечно, Title может быть ключом, но я думаю, что это будет замедлять поиск.
        public int ID { get; set; }

        public string Title { get; set; }
    }
}