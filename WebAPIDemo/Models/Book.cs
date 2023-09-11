using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIDemo.Models
{
    [Table("Book")]
    public class Book
    {
        [Key]
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required] 
        public string? AuthorName { get; set; }
        [Required]
        public int Price { get; set; }
    }
}

