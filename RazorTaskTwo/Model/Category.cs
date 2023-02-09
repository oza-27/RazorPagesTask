using System.ComponentModel.DataAnnotations;

namespace RazorTaskTwo.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime isCreatedOn { get; set; } = DateTime.Now;
        public DateTime isModifiedOn { get; set; } = DateTime.Now;
    }
}
