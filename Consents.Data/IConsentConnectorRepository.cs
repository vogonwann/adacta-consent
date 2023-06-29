using Consents.Data.Models;

namespace Consents.Data;

public interface IConsentConnectorRepository
{
    void AddConsent(Consent? consent);
    Consent? GetConsent(int userId, string consentType);
    void RevokeConsent(Consent consent); 
    
}