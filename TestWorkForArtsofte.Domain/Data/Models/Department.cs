namespace TestWorkForArtsofte.Domain.Models
{
    public class Department
    {
        //Конечно, Title может быть ключом, но я думаю, что это будет замедлять поиск.
        public int ID { get; set; }

        public string Title { get; set; }

        public int Floor { get; set; }
    }
}