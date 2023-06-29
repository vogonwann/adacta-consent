namespace Consents.Data.Worker;

public class ConsentUnitOfWork : IConsentUnitOfWork
{
    private readonly IConsentDbContext _dbContext;

    public ConsentUnitOfWork(IConsentDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void SaveChanges()
    {
        _dbContext.SaveChanges();
    }
}