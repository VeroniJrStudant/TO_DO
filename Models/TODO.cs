using System.ComponentModel.DataAnnotations;

namespace TO_DO.Models
{
    public class ToDo
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Done { get; set; }
    }
}
