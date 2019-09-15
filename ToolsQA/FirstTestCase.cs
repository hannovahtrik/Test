using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;



namespace ToolsQA
{
    class FirstTestCase
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://transport.tallinn.ee/#tallinna-linn/map";
        }
    }
}
