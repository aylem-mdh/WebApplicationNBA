using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebApplicationNBA.Tests;

[TestFixture]
public class SeleniumTests
{
    [Test]
    public void Swagger_Should_Load_With_Selenium()
    {
        var options = new ChromeOptions();

        using var driver = new ChromeDriver(options);

        driver.Navigate().GoToUrl("https://localhost:44350/swagger/index.html");

        Assert.That(driver.Title, Does.Contain("Swagger"));
    }
}
