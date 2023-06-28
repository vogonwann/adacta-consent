using Consents.Data;

namespace PostgresConnector;

public class Connector: IDataConnector<Connection>
{
    public Connection Connection { get; set; }

    public bool Connect()
    {
        throw new NotImplementedException();
    }

    public Connector(Connection connection)
    {
        Connection = connection;
        Connection.Create();
    }

    ~Connector()
    {
        Connection.Destroy();
    }
    
}