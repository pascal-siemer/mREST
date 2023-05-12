namespace MinApi.Endpoints;

public interface IEndpoint<T>
{
    public List<T> Get();
}