using System.ComponentModel.DataAnnotations;

namespace StudentMVCWeb.Models
{
    public class Book
    {
        public int BookId { get; set; }

        [Required]
        [Display()]
        public string BookName { get; set; } = string.Empty;

        public decimal Price { get; set; }
    }
}
