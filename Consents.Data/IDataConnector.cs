namespace Consents.Data;

/// <summary>
/// 
/// </summary>
public interface IDataConnector<TConnection>
{
    TConnection Connection { get; set; }
    bool Connect();
}