using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Fastly.Runners.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class FastlyOpenApiClientRunnerTests : FixturedUnitTest
{
    public FastlyOpenApiClientRunnerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
