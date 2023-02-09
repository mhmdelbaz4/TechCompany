
namespace TechCompany.Models
{
    public class MediaType
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200,MinimumLength =2)]
        public string Title { get; set; }

        public string ImagePath { get; set; }

        [ForeignKey("MediaTypeId")]
        public ICollection<CategoryItem> CategoryItems { get; set; }
    }
}
