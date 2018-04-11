using Microsoft.EntityFrameworkCore;

namespace SMATProgram.Models
{
    public class SiteInfoContext : DbContext
    {
        public SiteInfoContext(DbContextOptions<SiteInfoContext> options) : base(options)
        {

        }

        public DbSet<SiteInfo> SiteInfo { get; set; }
    }
}