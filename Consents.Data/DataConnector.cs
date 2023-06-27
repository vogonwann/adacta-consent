namespace Consents.Data;

public abstract class DataConnector : IDataConnector<IConnection>
{
    private readonly IConnection _connection;
    public abstract bool Connect();

    protected DataConnector(IConnection connection)
    {
        _connection = connection;
    }
}