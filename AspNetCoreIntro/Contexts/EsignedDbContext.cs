using Microsoft.EntityFrameworkCore;

namespace AspNetCoreIntro.Contexts
{
    public class EsignedDbContext : DbContext 
    {

        public EsignedDbContext(DbContextOptions<EsignedDbContext> options):base(options)
        {
            
        }
    }
}
