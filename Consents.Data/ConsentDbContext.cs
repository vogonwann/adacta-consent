using Consents.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Consents.Data;

public class ConsentDbContext: DbContext, IConsentDbContext
{
    public ConsentDbContext(DbContextOptions<ConsentDbContext> options): base(options)
    {
    }

    public DbSet<Consent?> Consents { get; set; }
    public void SaveChanges()
    {
        base.SaveChanges();
    }
}