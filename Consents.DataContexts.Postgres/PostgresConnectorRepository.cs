using Consents.Data;
using Consents.Data.Models;

namespace PostgresConnector;

public class PostgresConnectorRepository: IConsentConnectorRepository
{
    private readonly IConsentDbContext _dbContext;

    public PostgresConnectorRepository(IConsentDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void AddConsent(Consent? consent)
    {
        throw new NotImplementedException();
    }

    public Consent? GetConsent(int userId, string consentType)
    {
        throw new NotImplementedException();
    }

    public void RevokeConsent(Consent consent)
    {
        throw new NotImplementedException();
    }
}