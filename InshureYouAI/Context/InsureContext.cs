using InshureYouAI.Entities;
using Microsoft.EntityFrameworkCore;

namespace InshureYouAI.Context
{
    public class InsureContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=DESKTOP-MPV3150\\SQLEXPRESS;Initial Catalog=InsureDb;Integrated Security=True;TrustServerCertificate=True");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<AboutItem> AboutItems { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }    
        public DbSet<Message> Messages { get; set; }    
        public DbSet<PricingPlan> PricingPlans { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Slider> Sliders { get; set; }  
        public DbSet<Testimonial> Testimonials { get; set; }  
        public DbSet<TrailerVideo> TrailerVideos { get; set; }  

    }
}
