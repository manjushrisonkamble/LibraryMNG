using System.ComponentModel.DataAnnotations;

namespace LibraryMNG.Models
{
    public class Book
    {
        [Key]
        [Required]
        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public DateTime PublishDate { get; set; }
        public string Status { get; set; }
    }
}
