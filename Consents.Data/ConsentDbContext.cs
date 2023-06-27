using Microsoft.EntityFrameworkCore;

namespace Consents.Data;

public class ConsentDbContext: DbContext
{
    private readonly string _connectionString;

    public ConsentDbContext(string connectionString, DbType)
    {
        _connectionString = connectionString;
    }

    public override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        
    }
}