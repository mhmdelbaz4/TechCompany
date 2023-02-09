namespace TechCompany.Models
{
    public class CategoryItem
    {
    
        public int Id { get; set; }

        [Required]
        [StringLength(200 ,MinimumLength =2)]
        public string Title { get; set; }


        [StringLength(2000 ,MinimumLength =2)]
        public string Description { get; set; }

        public DateTime DateTimeReleased { get; set; }

        public int CategoryId { get; set; }

        public int MediaTypeId { get; set; }
    
    }
}
