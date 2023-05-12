using System.Data;

namespace MinApi.Sql.Mapper;

public interface IDataMapper<out T>
{
    public T Map(IDataRecord dataRecord);
}