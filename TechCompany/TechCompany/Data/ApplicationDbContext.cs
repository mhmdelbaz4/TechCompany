using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace TechCompany.Data
{

    public class ApplicationUser : IdentityUser
    {
        [StringLength(50)]
        public string FirstName { get; set; }
        
        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(250)]
        public string Address1 { get; set; }

        [StringLength(250)]
        public string Address2 { get; set; }

        [StringLength(50)]
        public string PostCode { get; set; }


        [ForeignKey("UserId")]
        public ICollection<UserCategory> UserCategory { get; set; }

    }
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Category { get; set; }
        public DbSet<CategoryItem> CategoryItem{ get; set; }
        public DbSet<Content> Content { get; set; }
        public DbSet<MediaType> MediaType { get; set; }
        public DbSet<UserCategory> UserCategory { get; set; }



    }
}