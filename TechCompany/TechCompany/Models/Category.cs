namespace TechCompany.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200,MinimumLength =2)]
        public string Title { get; set; }

        [Required]
        [StringLength(2000,MinimumLength =10)]
        public string Description { get; set; }

        public string ImagePath { get; set; }


        [ForeignKey("CategoryId")]
        public ICollection<CategoryItem> CategoryItems { get; set; }


        [ForeignKey("CategoryId")]
        public ICollection<UserCategory> UserCategory { get; set; }
    }
}
