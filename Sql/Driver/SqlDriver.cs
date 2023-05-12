using System.Data.SqlClient;
using MinApi.Sql.Mapper;

namespace MinApi.Sql.Driver;

public class SqlDriver : ISqlDriver
{
    private SqlConnection Connection { get; }

    public SqlDriver(string connectionString)
    {
        Connection = new SqlConnection(connectionString);
    }
    


    public List<T> Read<T>(string query, IDataMapper<T> mapper)
    {

        Connection.Open();
        
        var reader = new SqlCommand(query, Connection).ExecuteReader();

        var results = new List<T>();
        
        while (reader.Read())
        {
            results.Add(mapper.Map(reader));
        }

        reader.Close();
        
        Connection.Close();

        return results;
    }

    public void Dispose()
    {
        Connection.Dispose();
    }

}