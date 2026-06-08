using Microsoft.Playwright;
using NUnit.Framework;

namespace WebApplicationNBA.Tests;

[TestFixture]
public class SwaggerTests
{
    [Test]
    public async Task Swagger_Should_Load()
    {
        using var playwright = await Playwright.CreateAsync();

        await using var browser = await playwright.Chromium.LaunchAsync(
            new BrowserTypeLaunchOptions
            {
                Headless = false
            });

        var page = await browser.NewPageAsync();

        await page.GotoAsync("https://localhost:44350/swagger/index.html"); 

        Assert.That(await page.TitleAsync(), Does.Contain("Swagger"));
    }
}