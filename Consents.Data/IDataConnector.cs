namespace Consents.Data;

/// <summary>
/// 
/// </summary>
public interface IDataConnector<TConnection>
{
    bool Connect();
}