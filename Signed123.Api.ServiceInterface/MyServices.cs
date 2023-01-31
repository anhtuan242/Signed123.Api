using ServiceStack;
using Signed123.Api.ServiceModel;

namespace Signed123.Api.ServiceInterface;

public class MyServices : Service
{
    public object Any(Hello request)
    {
        return new HelloResponse { Result = $"Hello, {request.Name}!" };
    }
}