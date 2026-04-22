using Soenneker.Tests.HostedUnit;

namespace Soenneker.Fastly.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class FastlyOpenApiClientRunnerTests : HostedUnitTest
{
    public FastlyOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
