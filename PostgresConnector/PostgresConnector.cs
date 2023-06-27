using Consents.Data;

namespace PostgresConnector;

public class PostgresConnector: DataConnector
{
    public override bool Connect()
    {
        throw new NotImplementedException();
    }

    public PostgresConnector(IConnection connection) : base(connection)
    {
    }
}