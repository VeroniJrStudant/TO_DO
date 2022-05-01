using System.ComponentModel.DataAnnotations;

namespace TO_DO.Models
{
    public class TODO
    {
        [Key]
        public  int Id { get; set; }
        public string Title { get; set; }
        public int CreatedDate { get; set; }
        public bool Done { get; set; }
    }
}
