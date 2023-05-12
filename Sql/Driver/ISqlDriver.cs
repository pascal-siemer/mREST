using MinApi.Sql.Mapper;

namespace MinApi.Sql.Driver;

public interface ISqlDriver : IDisposable
{
    public List<T> Read<T>(string query, IDataMapper<T> mapper);
}