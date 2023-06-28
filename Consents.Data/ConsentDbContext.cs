using Microsoft.EntityFrameworkCore;

namespace Consents.Data;

public class ConsentDbContext: DbContext
{
    private readonly string _connectionString;

    public ConsentDbContext(string connectionString, ConsentDbType)
    {
        _connectionString = connectionString;
    }

    public override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        
    }
}