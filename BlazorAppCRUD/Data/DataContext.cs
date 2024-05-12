using BlazorAppCRUD.Entity;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppCRUD.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options) 
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySql("server=localhost;user=root;password=;database=BlazorCrud_db",
                new MySqlServerVersion(new Version(8, 0, 0)));


        }
        public DbSet<Game> Games { get; set; }  
    }
}
