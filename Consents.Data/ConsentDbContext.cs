using Microsoft.EntityFrameworkCore;

namespace Consents.Data;

public class ConsentDbContext: DbContext
{
    private readonly string _connectionString;

    public ConsentDbContext(string connectionString)
    {
        _connectionString = connectionString;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        
    }
}