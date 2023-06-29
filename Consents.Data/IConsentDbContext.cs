using Consents.Data.Models;
using Consents.Data.Worker;
using Microsoft.EntityFrameworkCore;

namespace Consents.Data;

public interface IConsentDbContext: IConsentUnitOfWork
{
    DbSet<Consent> Consents { get; set; }
}