using angular_dotnet_core.Models;
using Microsoft.EntityFrameworkCore;

namespace angular_dotnet_core.Infrastructure
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base (options){

        }

        public DbSet<Make> Makes { get; set; }
    }
}