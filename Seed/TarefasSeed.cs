using TO_DO.Models;

namespace TO_DO.Seed
{
    public class TarefasSeed
    {
        public static List<TODO> Seed { get; set; } = new List<TODO>()
        { new TODO
            {
                Id = 1,
                Title = "exemplo1",
                CreatedDate = 01/01/2022,
                Done = true,
            }
        };
    }
}
