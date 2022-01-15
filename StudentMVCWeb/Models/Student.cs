using System.ComponentModel.DataAnnotations;

namespace StudentMVCWeb.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is Required*")]
        [StringLength(100)]
        public string Name { get; set; }= String.Empty;

        [Required(ErrorMessage = "Email is Required*")]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; } = String.Empty;

        [Required(ErrorMessage = "Mobile is Required*")]
       
        public string Mobile { get; set; } = String.Empty;

        [Required(ErrorMessage = "Description is Required*")]
        public string Description { get; set; } = String.Empty;
    }
}
