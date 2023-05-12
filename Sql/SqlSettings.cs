using System.Data.SqlClient;
using MinApi.Sql.Driver;
using MinApi.Sql.Mapper;

namespace MinApi.Sql;

public class SqlSettings<T>
{
    public ISqlDriver Driver { get; set; }
    public string Query { get; set; }
    public IDataMapper<T> Mapper { get; set; }

    
    public SqlSettings(ISqlDriver driver, string query, IDataMapper<T> mapper)
    {
        Driver = driver;
        Query = query;
        Mapper = mapper;
    }

}