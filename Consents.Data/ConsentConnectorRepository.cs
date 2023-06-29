using Consents.Data.Models;

namespace Consents.Data;

/// <summary>
/// 
/// </summary>
public class ConsentConnectorRepository : IConsentConnectorRepository
{
    private readonly IConsentDbContext _dbContext;

    public ConsentConnectorRepository(IConsentDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void AddConsent(Consent? consent)
    {
        _dbContext.Consents.Add(consent);
    }

    public Consent? GetConsent(int userId, string consentType)
    {
        return _dbContext.Consents
            .FirstOrDefault(c => c != null && c.UserId == userId && c.ConsentType == consentType);
    }

    public void RevokeConsent(Consent consent)
    {
        _dbContext.Consents.Remove(consent);
    }
}