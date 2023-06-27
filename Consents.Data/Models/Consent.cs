namespace Consents.Data.Models;

public class Consent
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string ConsentType { get; set; }
    public DateTime ValidFrom { get; set; }
    public DateTime ValidTo { get; set; }
}