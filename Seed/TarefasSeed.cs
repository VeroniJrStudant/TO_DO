using TO_DO.Models;

namespace TO_DO.Seed
{
    public class TarefasSeed
    {
        public static List<ToDo> Seed { get; set; } = new List<ToDo>()
        { new ToDo
            {
                Id = 1,
                Title = "exemplo1",
                CreatedDate = DateTime.Now,
                Done = false,
            }
        };
    }
}
