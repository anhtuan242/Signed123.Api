using NUnit.Framework;
using ServiceStack;
using ServiceStack.Testing;
using Signed123.Api.ServiceInterface;


namespace Signed123.Api.Tests;

public class UnitTest
{
    private readonly ServiceStackHost appHost;

    public UnitTest()
    {
        appHost = new BasicAppHost().Init();
        appHost.Container.AddTransient<MyServices>();
    }

    [OneTimeTearDown]
    public void OneTimeTearDown() => appHost.Dispose();

}