using Microsoft.AspNetCore.Mvc.Testing;
using NUnit.Framework;
using System.Net.Http;
using WebApplicationNBA;

public class PlayersTests
{
    private HttpClient _client = null!;

    [SetUp]
    public void Setup()
    {
        var factory = new WebApplicationFactory<Program>();
        _client = factory.CreateClient();
    }

    [TearDown]
    public void TearDown()
    {
        _client.Dispose();
    }

    [Test]
    public async Task GetPlayers_ShouldReturnSuccess()
    {
        var response = await _client.GetAsync("/api/Players");

        Assert.That(response.IsSuccessStatusCode, Is.True);
    }
}