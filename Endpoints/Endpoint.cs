using MinApi;
using MinApi.Endpoints;
using MinApi.Sql;
using MinApi.Sql.Driver;
using MinApi.Sql.Mapper;

public class Endpoint<T> : IEndpoint<T>, IDisposable
{
    private ISqlDriver _sqlDriver;
    private string _query;
    private IDataMapper<T> _mapper;

    public Endpoint(SqlSettings<T> settings)
    {
        _sqlDriver = settings.Driver;
        _query = settings.Query;
        _mapper = settings.Mapper;
    }

    public List<T> Get() => _sqlDriver.Read(_query, _mapper);



    public void Dispose()
    {
        _sqlDriver.Dispose();
    }
}