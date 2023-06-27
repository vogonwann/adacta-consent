using Consents.Data;

namespace Consents.DataConnectors.MariaDb;

public class Connector: IDataConnector<Connection>
{
    public Connection Connection { get; set; }
    public bool Connect()
    {
        throw new NotImplementedException();
    }
}