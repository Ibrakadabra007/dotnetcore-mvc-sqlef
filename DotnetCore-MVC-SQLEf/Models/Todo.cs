using System.ComponentModel.DataAnnotations;

namespace DotnetCore_MVC_SQLEf.Models
{
    public class Todo
    {
        [Key]
        [Required]
        public int ID { get; set; }
        public string? Description { get; set; }

        [Display(Name = "Created Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }

    }
}
