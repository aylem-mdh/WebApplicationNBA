using System.Net.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using NUnit.Framework;

namespace WebApplicationNBA.Tests;

[TestFixture]
public class PlayersTests
{
    private WebApplicationFactory<Program> _factory = null!;
    private HttpClient _client = null!;

    [SetUp]
    public void Setup()
    {
        _factory = new WebApplicationFactory<Program>()
            .WithWebHostBuilder(builder =>
            {
                builder.UseEnvironment("Testing");
            });

        _client = _factory.CreateClient();
    }

    [TearDown]
    public void TearDown()
    {
        _client.Dispose();
        _factory.Dispose();
    }

    [Test]
    public async Task GetPlayers_ShouldReturnSuccess()
    {
        var response = await _client.GetAsync("/api/Players");

        var body = await response.Content.ReadAsStringAsync();

        TestContext.WriteLine("STATUS: " + response.StatusCode);
        TestContext.WriteLine("BODY: " + body);

        Assert.That(response.IsSuccessStatusCode, Is.True);
    }
}


